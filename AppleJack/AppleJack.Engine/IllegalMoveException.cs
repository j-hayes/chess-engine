using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleJack.Engine
{
    public class IllegalMoveException : Exception
    {
        public int Fromi { get; set; }
        public int Toi { get; set; }

        public IllegalMoveException(string message):base(message)
        {
           
        }

        public IllegalMoveException(string message, int fromi, int toi) : base(message)
        {
            Fromi = fromi;
            Toi = toi;
        }


    }
}
