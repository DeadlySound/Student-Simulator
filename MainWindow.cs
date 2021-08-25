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
        private Lazy<NewGameWindow> _newGame = new Lazy<NewGameWindow>(() => new NewGameWindow());

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Quit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewGame_btn_Click(object sender, EventArgs e)
        {
            //ToggleMenuVisibility();
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

    }
}
