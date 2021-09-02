using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Simulator
{

    public partial class MainWindow : Form
    {
        public bool IsGameActive { 
            get => Continue_btn.Enabled;
            set => Continue_btn.Enabled = value;
        }
        private SqlConnection _connection = DatabaseManager.MakeDatabaseConnection();
        private Lazy<NewGameWindow> _newGame;
        public GameManager GameManager;
        private Student _player;

        public MainWindow()
        {
            InitializeComponent();
            _newGame = new Lazy<NewGameWindow>(() => new NewGameWindow(this));
            GameManager = new GameManager(this);
        }

        private void Quit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewGame_btn_Click(object sender, EventArgs e)
        {
            ToggleMenuVisibility();
            _newGame.Value.Clear();
            _newGame.Value.ShowDialog();
        }
        private void Continue_btn_Click(object sender, EventArgs e)
        {
            ToggleMenuVisibility();
        }

        public void ToggleMenuVisibility()
        {
            MenuPanel.Visible = !MenuPanel.Visible;
        }
        
        public void CreateStudent(int id, string nickname, string fieldOfStudy)
        {
            var skillset = CreateSkillsetForTerm(1, fieldOfStudy);
            _player = new Student(id, nickname, fieldOfStudy, skillset);
        }

        Dictionary<string, int> CreateSkillsetForTerm(int term, string fieldOfStudy)
        {
            var tempListOfSubjects = DatabaseManager.RetrieveListOfSubjectsForTerm(term, fieldOfStudy);
            var skillset = new Dictionary<string, int>();
            foreach (var subject in tempListOfSubjects)
            {
                skillset.Add(subject, 0);
            }
            return skillset;
        }

        public void SetPlayerIndicators(int time)
        {
            PlayerIndicator_UserControl.MentalHealth = _player.MentalHealth;
            PlayerIndicator_UserControl.PhysicalHealth = _player.PhysicalHealth;
            PlayerIndicator_UserControl.Time = time;
        }
        public void SetPlayerIndicators((int PH, int MH, int Time) indicatorsTuple)
        {
            // player property setters already have filters for values
            _player.MentalHealth = indicatorsTuple.MH;
            _player.PhysicalHealth = indicatorsTuple.PH;

            PlayerIndicator_UserControl.MentalHealth = _player.MentalHealth;
            PlayerIndicator_UserControl.PhysicalHealth = _player.PhysicalHealth;
            PlayerIndicator_UserControl.Time = indicatorsTuple.Time;
        }

        private void Menu_btn_Click(object sender, EventArgs e)
        {
            ToggleMenuVisibility();
        }

        private void EndTurn_btn_Click(object sender, EventArgs e)
        {
            GameManager.NextTurn(new (_player.MentalHealth+5, _player.PhysicalHealth, 100));
        }

        public void InsertSubjectsInListbox()
        {
            //TODO insert the skillset on a form in a cleaner way (to eliminate problems when skillset list becomes too long)
            // currenltly there are 2 listboxes that need to be scrolled separately
            SkillsetName_listbox.BeginUpdate();
            SkillsetLevel_listbox.BeginUpdate();
            foreach (var skill in _player.Skillset)
            {
                SkillsetName_listbox.Items.Add(skill.Key);
                SkillsetLevel_listbox.Items.Add(skill.Value);
            }
            SkillsetName_listbox.EndUpdate();
            SkillsetLevel_listbox.EndUpdate();
        }

        public void WriteWeeklyScheduleOnScreen()
        {
            WeeklySchedule_label.Text = GameManager.Schedule.ToString();
        }
    }
}
