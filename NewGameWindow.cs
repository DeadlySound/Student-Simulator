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
    public partial class NewGameWindow : Form
    {
        private MainWindow MainWindowReferrence;
        private bool _isClosingForNewGame;
        public NewGameWindow()
        {
            InitializeComponent();
        }
        public NewGameWindow(MainWindow mwReferrence)
        {
            InitializeComponent();
            MainWindowReferrence = mwReferrence;
            //TODO get a list of fields of study from database and make radiobuttons out of them to choose

        }

        public void Clear()
        {
            NicknameInput_textBox.Text = string.Empty;
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            if (!ErrorProviderChecksPassed()) { return; }
            DatabaseManager.AddStudentToDatabase(NicknameInput_textBox.Text);
            int studentId = DatabaseManager.RetrieveLastStudentId();
            MainWindowReferrence.CreateStudent(studentId, NicknameInput_textBox.Text, FieldOfStudy_checkbox.Text);
            MainWindowReferrence.GameManager.StartGame(1, FieldOfStudy_checkbox.Text);
            _isClosingForNewGame = true;
            Close();
        }

        bool ErrorProviderChecksPassed()
        {
            Textbox_ErrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(NicknameInput_textBox.Text))
            {
                Textbox_ErrorProvider.SetError(NicknameInput_textBox, "Your nickname can't be empty");
                return false;
            }
            if (NicknameInput_textBox.Text.Length > 32)
            {
                Textbox_ErrorProvider.SetError(NicknameInput_textBox, "Your nickname can't be longer than 32 characters");
                return false;
            }
            return true;
        }

        void OnClosing(object sender, EventArgs e)
        {
            if (!_isClosingForNewGame)
            {
                MainWindowReferrence.ToggleMenuVisibility();
            }
        }
    }
}
