using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Messages
    {
        private String userID1;
        private String userID2;
        private String message;
        public Messages(String userID1, String userID2, String message)
        {
            this.userID1 = userID1;
            this.userID2 = userID2;
            this.message = message;
        }
    }
}
