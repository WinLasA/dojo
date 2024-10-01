using System.Drawing;

namespace TicTacToe
{
    public class Board
    {
        private const char EMPTY = ' ';

        private readonly char[,] _board;
        public Board(int size)
        {
            _board = new char[size, size];
            Init();
        }

        private void Init()
        {
            for (var y = 0; y < _board.GetLength(0); y++)
            {
                for (var x = 0; x < _board.GetLength(1); x++)
                {
                    _board[y, x] = EMPTY;
                }
            }
        }

        public void SetBoard(Point point, char symbol) => _board[point.Y, point.X] = symbol;
        public char[,] GetBoard() => _board;

        public bool IsWinning(char symbol)
        {
            //Horiz
            for (var y = 0; y < _board.GetLength(0); y++)
            {
                var countX = 0;
                for (var x = 0; x < _board.GetLength(1); x++)
                {
                    if (_board[y, x] == symbol)
                        countX++;
                }
                if (countX == _board.GetLength(0))
                    return true;
            }

            //Vert
            for (var x = 0; x < _board.GetLength(1); x++)
            {
                var countY = 0;
                for (var y = 0; y < _board.GetLength(0); y++)
                {
                    if (_board[y, x] == symbol)
                        countY++;
                }
                if (countY == _board.GetLength(0))
                    return true;
            }

            //diagonal
            var count = 0;
            for (var y = 0; y < _board.GetLength(0); y++)
            {
                for (var x = 0; x < _board.GetLength(1); x++)
                {
                    if (x == y && _board[y, x] == symbol)
                        count++;
                }

                if (count == _board.GetLength(0))
                    return true;
            }

            count = 0;
            for (var y = 0; y < _board.GetLength(0); y++)
            {
                for (var x = 0; x < _board.GetLength(1); x++)
                {
                    if (x == _board.GetLength(0) - 1 - y && _board[y, x] == symbol)
                        count++;
                }

                if (count == _board.GetLength(0))
                    return true;
            }



            return false;
        }

        public bool IsOccupied(Point point)
        {
            return _board[point.Y, point.X] != EMPTY;
        }

        public bool IsFull()
        {
            for (var y = 0; y < _board.GetLength(0); y++)
            {
                for (var x = 0; x < _board.GetLength(1); x++)
                {
                    if (_board[y, x] == EMPTY)
                        return false;
                }
            }

            return true;
        }
    }
}
