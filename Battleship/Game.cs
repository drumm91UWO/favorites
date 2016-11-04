using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Game
    {
        private int gameID;
        private Users player1ID;
        private Users Player2ID;
        private String Board1;
        private String Board2;
        private List<Move> moves;
        private bool isOver;
        private int isTurn;

        public bool UpdateSunkShipCount()
        {
            return true;
        }

        public bool InsertMove(int move1, int move2)
        {
            return true;
        }

        public bool CheckForHit(int move1, int move2)
        {
            return true;
        }

        public String Draw()
        {
            return "Hai";
        }

        private bool CheckForSunkShip(String[,] Board)
        {
            return true;
        }

        private void GameThread()
        {
            //:D
        }

        public bool SaveGame()
        {
            return true;
        }
    }
}
