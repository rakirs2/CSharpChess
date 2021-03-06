using System.Dynamic;

namespace CSharpChess.Models
{
    public class ChessSquare
    {
        public  bool Occupied { get; set; }
        public bool IsBlack { get; set; }



        public ChessSquare(int rank, int file)
        {
            Occupied = false;
            IsBlack = rank+file%2==0;

        }
        public ChessSquare()
        {
            Occupied = false;
            IsBlack= false;
            
        }

        public override string ToString()
        {
            return IsBlack ? "....." : "     ";
        }
    }
}