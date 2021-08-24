using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Simulator
{
    
    public partial class MainWindow : Form
    {
        private DatabaseManager DBManager = new DatabaseManager();
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
            ToggleMenuVisibility();
        }

        private void ToggleMenuVisibility()
        {
            MenuPanel.Visible = !MenuPanel.Visible;
        }

        private void DBC_Click(object sender, EventArgs e)
        {
            using var connection = DBManager.OpenDatabaseConnection();
            DBManager.CloseDatabaseConnection(connection);
        }

    }
}
