using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Simulator
{
    public class GameManager
    {
        #region Properties and Fields

        private MainWindow _mainWindowReferrence;
        public int CurrentTurn { get; set; } = 1;
        public WeeklySchedule Schedule { get; set; }
        #endregion

        #region Constructors
        public GameManager(MainWindow mwReferrence)
        {
            _mainWindowReferrence = mwReferrence;
        }
        #endregion

        #region Functions
        public void StartGame(int term, string fieldOfStudy)
        {
            _mainWindowReferrence.IsGameActive = true;
            Schedule = new WeeklySchedule(DatabaseManager.RetrieveListOfSubjectsForTerm(term, fieldOfStudy));
            _mainWindowReferrence.WriteWeeklyScheduleOnScreen();
            _mainWindowReferrence.SetPlayerIndicators(100);
            _mainWindowReferrence.InsertSubjectsInListbox();
        }

        public void NextTurn((int PH, int MH, int Time) indicatorsTuple)
        {
            _mainWindowReferrence.SetPlayerIndicators(indicatorsTuple);
            CurrentTurn++;
        }
        #endregion
    }
}