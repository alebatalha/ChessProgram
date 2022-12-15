using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardChessGame;

namespace GameBoard
{
    class ChessBoard
    {
        public int lines { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;

        public ChessBoard( int lines, int columns)
        {
            this.lines = lines;
            this.columns = columns;
            pieces = new Piece[lines, columns];
        }
        public Piece piece(int line, int column)
        {
            return pieces[line, column];
        }
        public Piece piece(Position pos) 
        {
            return pieces[pos.line, pos.column];
        }
        public bool legalPossition(Position pos)
        {
            validPossitions(pos);
            return piece(pos) != null;
        }

        public void puttingPiece(Piece p, Position pos)
        {
            pieces[pos.line, pos.column] = p;
            p.position = pos;
        }
        // testing if my possitiong is valid
        public bool possitionLegal(Position pos)
        {
            if (pos.line < 0 || pos.line >= lines || pos.column < 0 || pos.column >= columns)
            {
                return false;
            }
            return true;
        }

        public void validPossitions(Position pos)
        {
            if (!possitionLegal(pos))
            {
                throw new GameBoardExceptions("this possitions is invalid");
            }
        }
        // end of the test
    }

}
