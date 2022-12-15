using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardChessGame;

namespace GameBoard
{
    class Piece
    {
        public Position position{ get; set; }  
        public Colour colour { get; protected set; }
        public int numMove { get; protected set;  }
        public ChessBoard board { get; protected set;  }

        public Piece(ChessBoard board, Colour colour)
        {
            this.position = null;
            this.colour = colour;
            this.board = board;
            this.numMove = 0;
           }
            
            
            
    }
}
