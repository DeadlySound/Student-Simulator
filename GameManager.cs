using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Simulator
{
    public class GameManager
    {
        #region Properties and Fields

        private MainWindow _mainWindowReferrence;
        public DateTime CurrentTurn { get; set; } 
        public WeeklySchedule Schedule { get; set; }
        readonly CultureInfo _culture = new ("en");
        #endregion

        #region Constructors
        public GameManager(MainWindow mwReferrence)
        {
            _mainWindowReferrence = mwReferrence;
            CurrentTurn = new(2021, 10, 1);
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
            //culture setting for date format
            _mainWindowReferrence.WriteCurrentTurnOnScreen(CurrentTurn.ToString(_culture.DateTimeFormat.LongDatePattern, _culture));
        }

        public void NextTurn((int PH, int MH, int Time) indicatorsTuple)
        {
            _mainWindowReferrence.AdjustPlayerIndicators(indicatorsTuple);
            CurrentTurn = CurrentTurn.AddDays(1);
            _mainWindowReferrence.WriteCurrentTurnOnScreen(CurrentTurn.ToString(_culture.DateTimeFormat.LongDatePattern, _culture));
        }
        #endregion
    }
}