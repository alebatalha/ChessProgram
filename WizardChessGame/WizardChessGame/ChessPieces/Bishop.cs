using System;
using System.Collections.Generic;
using System.Text;
using GameBoard;
using WizardChessGame;


namespace Chess
{
    class Bishop : Piece
    {
        public Bishop(ChessBoard board, Colour colour) : base(board, colour)
        {

        }
        public override string ToString()
        {
            return "B";
        }

    }
}
