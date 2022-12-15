using System;
using System.Collections.Generic;
using System.Text;
using GameBoard;


namespace Chess
{
    class Rook : Piece
    {
        public Rook(ChessBoard board, Colour colour) : base(board, colour)
        {

        }
        public override string ToString()
        {
            return "R";
        }

    }
}
