using System;
using System.Collections.Generic;
using System.Text;
using GameBoard;


namespace Chess
{
    class King : Piece
    {
        public King(ChessBoard board, Colour colour) : base(board, colour)
        {

        }
        public override string ToString()
        {
            return "K";
        }
     
    }
}

