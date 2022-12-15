using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardChessGame;
using GameBoard;

namespace WizardChessGame
{
    class Screen
    {
        public static void printBoard( GameBoard.ChessBoard board)
        {
            for (int i=0; i < board.lines; i++) {
                for (int j=0; j < board.columns; j++ ){
                    if (board.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.WriteLine(board.piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        internal static void printBoard(object board)
        {
            throw new NotImplementedException();
        }
    }
}
