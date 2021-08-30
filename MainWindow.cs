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
        private SqlConnection _connection = DatabaseManager.MakeDatabaseConnection();
        private Lazy<NewGameWindow> _newGame;
        private Student _player;

        public MainWindow()
        {
            InitializeComponent();
            _newGame = new Lazy<NewGameWindow>(() => new NewGameWindow(this));
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

        private void ToggleMenuVisibility()
        {
            MenuPanel.Visible = !MenuPanel.Visible;
        }

        private void DBC_Click(object sender, EventArgs e)
        {

            DatabaseManager.OpenDatabaseConnection(_connection);

            DatabaseManager.CloseDatabaseConnection(_connection);
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
    }
}
