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
            set
            {
                PhysicalHealth_ProgressBar.Value = value;
            }
        }

        public int MentalHealth
        {
            set
            {
                MentalHealth_ProgressBar.Value = value;
            }
        }

        public int Time
        {
            set
            {
                Time_ProgressBar.Value = Math.Min(24, Math.Max(0, value));
            }
        }
        public PlayerIndicator()
        {
            InitializeComponent();
        }

    }
}
