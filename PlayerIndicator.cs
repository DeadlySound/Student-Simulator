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
    public partial class PlayerIndicator : UserControl
    {
        public int PhysicalHealth
        {
            get => PhysicalHealth_ProgressBar.Value;
            set => PhysicalHealth_ProgressBar.Value = value;
        }

        public int MentalHealth
        {
            get => MentalHealth_ProgressBar.Value;
            set => MentalHealth_ProgressBar.Value = value;
        }

        public int Time
        {
            get => Time_ProgressBar.Value;
            set => Time_ProgressBar.Value = Math.Min(24, Math.Max(0, value));
        }
        public PlayerIndicator()
        {
            InitializeComponent();
        }

        private void PlayerIndicator_Load(object sender, EventArgs e)
        {

        }
    }
}
