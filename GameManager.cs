using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Simulator
{
    public class GameManager
    {
        #region Properties

        private MainWindow _mainWindowReferrence;
        #endregion

        #region Constructors
        public GameManager(MainWindow mwReferrence)
        {
            _mainWindowReferrence = mwReferrence;
        }
        #endregion
        public void StartGame()
        {
            _mainWindowReferrence.SetPlayerIndicators(100);
        }
    }
}
