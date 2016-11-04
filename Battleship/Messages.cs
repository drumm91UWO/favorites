using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Messages
    {
        private String UserID1;
        private String UserID2;
        private String Message;
        public Messages(String UserID1, String UserID2, String Message)
        {
            this.UserID1 = UserID1;
            this.UserID2 = UserID2;
            this.Message = Message;
        }
    }
}
