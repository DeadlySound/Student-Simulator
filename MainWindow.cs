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

        public void AdjustPlayerIndicators((int PH, int MH, int Time) indicatorsTuple)
        {
            _player.MentalHealth += indicatorsTuple.MH;
            _player.PhysicalHealth += indicatorsTuple.PH;

            PlayerIndicator_UserControl.MentalHealth = _player.MentalHealth;
            PlayerIndicator_UserControl.PhysicalHealth = _player.PhysicalHealth;
            PlayerIndicator_UserControl.Time += indicatorsTuple.Time;
        }

        private void Menu_btn_Click(object sender, EventArgs e)
        {
            ToggleMenuVisibility();
        }

        private void EndTurn_btn_Click(object sender, EventArgs e)
        {
            GameManager.NextTurn(new (5, 5, 24));
            ResetActionButtons();
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

        public void UpdateSkillsetLevels()
        {
            SkillsetLevel_listbox.BeginUpdate();
            SkillsetLevel_listbox.Items.Clear();
            foreach (var skill in _player.Skillset)
            {
                SkillsetLevel_listbox.Items.Add(skill.Value);
            }
            SkillsetLevel_listbox.EndUpdate();
        }

        public void WriteWeeklyScheduleOnScreen()
        {
            WeeklySchedule_label.Text = GameManager.Schedule.ToString();
        }

        public void WriteCurrentTurnOnScreen(string currentTurn)
        {
            CurrentTurn_label.Text = currentTurn;
        }

        private void GoToUni_btn_Click(object sender, EventArgs e)
        {
            var todaysClasses = GameManager.Schedule.WeekdaysAndSubjects[GameManager.CurrentTurn.DayOfWeek];
            if (todaysClasses.Count == 0)
            {
                MessageBox.Show("There are no classes today");
            }
            else
            {
                foreach (var subject in todaysClasses)
                {
                    _player.Skillset[subject] += 2;
                }
                UpdateSkillsetLevels();
                MessageBox.Show("You successfully get out of the house and manage to sit through the classes");
                var timeWasted = -1 * todaysClasses.Count * 2 + 2;
                AdjustPlayerIndicators((-10, 0, timeWasted));
            }
            GoToUni_btn.Enabled = false;
        }

        void ResetActionButtons()
        {
            GoToUni_btn.Enabled = true;
        }

        private void GoSocialise_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You go out with your friends. Your physical health takes a hit since you got drunk again.");
            AdjustPlayerIndicators((5, -10, -5));
        }
    }
}
