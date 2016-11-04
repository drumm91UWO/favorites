using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class DataAccessLayer
    {
        private String[,] GetLayout1()
        {
            String[,] happy = new String[3, 3];
            return happy;
        }

        private String[,] GetLaout2()
        {
            String[,] happy = new String[3,3];
            return happy;
        }

        private String[,] GetFriends()
        {
            String[,] happy = new String[3, 3];
            return happy;
        }

        private bool IsOnline(String UserName)
        {
            return true;
        }
    }
}