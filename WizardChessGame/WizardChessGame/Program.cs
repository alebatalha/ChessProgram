using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardChessGame.Chess;
using GameBoard;
using Chess;

namespace WizardChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
        ChessBoard chessBoard = new ChessBoard(8,8);

            chessBoard.puttingPiece(new King(chessBoard, Colour.White) , new Position(9, 9));
            chessBoard.puttingPiece(new Pawn(chessBoard, Colour.White), new Position(1, 3));
            chessBoard.puttingPiece(new Rook(chessBoard, Colour.White), new Position(2, 4));

            Screen.printBoard(chessBoard);

            Console.ReadLine();       

        }
    }
}
