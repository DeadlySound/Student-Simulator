using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Student_Simulator
{
    class Student
    {
        private int _ID;
        private string _Nickname;
        Dictionary<int, int> Skillset; // Dictionary<SkillID,SkillLevel>

        public int MentalHealth {
            get => MentalHealth;
            set
            {
                MentalHealth = Math.Max(Math.Min(0, value), 100);
            }
        }

        public int PhysicalHealth
        {            
            get => PhysicalHealth;
            set
            {
                PhysicalHealth = Math.Max(Math.Min(0, value), 100);
            }
        }
    }
}
