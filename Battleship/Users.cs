using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Users
    {
        private int gamesWon, gamesLost, userID;
        
        public Users()
        {
            StatsWindow stats = new StatsWindow();
            gamesWon = stats.GetGamesWon();
            gamesLost = stats.GetGamesLost();
            //TODO assign userID
            userID = 0;
        }
    }
}
