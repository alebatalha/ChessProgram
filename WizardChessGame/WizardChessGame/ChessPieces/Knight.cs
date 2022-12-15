using System;
using System.Collections.Generic;
using System.Text;
using GameBoard;


namespace Chess
{
    class Knight : Piece
    {
        public Knight(ChessBoard board, Colour colour) : base(board, colour)
        {

        }
        public override string ToString()
        {
            return "H";
        }

    }
}
