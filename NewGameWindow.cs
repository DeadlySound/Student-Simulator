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
    public partial class NewGameWindow : Form
    {
        public NewGameWindow()
        {
            InitializeComponent();
        }

        private void NewGameWindow_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            NicknameInput_textBox.Text = string.Empty;
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            NoEmptyNickname_ErrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(NicknameInput_textBox.Text))
            {
                NoEmptyNickname_ErrorProvider.SetError(NicknameInput_textBox, "Your nickname can't be empty");
                return;
            }

        }
    }
}
