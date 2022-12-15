using System;
using System.Collections.Generic;
using System.Text;
using GameBoard;


namespace WizardChessGame.Chess
{
    class Queen : Piece
    {
        public Queen(ChessBoard board, Colour colour) : base(board, colour)
        {

        }
        public override string ToString()
        {
            return "Q";
        }

    }
}
