using System;
using System.Collections.Generic;
using System.Text;
using GameBoard;


namespace Chess
{
    class Pawn : Piece
    {
        public Pawn(ChessBoard board, Colour colour) : base(board, colour)
        {

        }
        public override string ToString()
        {
            return "P";
        }

    }
}
