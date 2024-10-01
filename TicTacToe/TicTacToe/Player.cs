using System.Drawing;

namespace TicTacToe
{
    public class Player
    {
        public static Random Random = new Random();

        private readonly int _size;
        public char Symbol { get;}
        public Player(int size, char symbol)
        {
            _size = size;
            Symbol = symbol;
        }

        public void Play(Board board)
        {
            var point = GetPoint();
            while (board.IsOccupied(point))
            {
                point = GetPoint();
            }
            board.SetBoard(point, Symbol);
        }

        public Point GetPoint()
        {
            return new Point
            {
                X = Random.Next(0, _size),
                Y = Random.Next(0, _size)
            };
        }
    }
}
