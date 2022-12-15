using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoard
{
    class GameBoardExceptions : Exception 
    {
        public GameBoardExceptions(string msg) : base(msg) { }
    }
}
