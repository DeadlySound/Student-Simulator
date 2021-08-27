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
        #region Fields and Properties
        private int _id;
        private string _nickname;
        private string _fieldOfStudy;
        public int CurrentTerm { get; set; }
        Dictionary<string, int> Skillset; // Dictionary<SkillID,SkillLevel>

        private int _mentalHealth;
        public int MentalHealth
        {
            get => MentalHealth;
            set => _mentalHealth = Math.Max(Math.Min(100, value), 0);
        }

        private int _physicalHealth;
        public int PhysicalHealth
        {
            get => PhysicalHealth;
            set => _physicalHealth = Math.Max(Math.Min(100, value), 0);
        }
        #endregion

        #region Constructors

        public Student(int id, string nickname, string fieldOfStudy)
        {
            _id = id;
            _nickname = nickname;
            _fieldOfStudy = fieldOfStudy;
            MentalHealth = 100;
            PhysicalHealth = 100;
            CurrentTerm = 1;
        }

        #endregion
    }
}
