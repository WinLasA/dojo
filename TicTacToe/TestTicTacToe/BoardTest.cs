using System.Drawing;
using TicTacToe;

namespace TestTicTacToe
{
    public class BoardTest
    {
        [Fact]
        public void IsFull_InputIsFull_ShouldReturnTrue()
        {
            var size = 3;
            var board = new Board(size);

            for (var y = 0; y < size; y++)
            {
                for (var x = 0; x < size; x++)
                {
                    board.SetBoard(new Point(x, y), 'X');
                }
            }

            var result = board.IsFull();

            Assert.True(result);
        }

        [Fact]
        public void IsFull_InputIsNotFull_ShouldReturnFalse()
        {
            var size = 3;
            var board = new Board(size);
            var result = board.IsFull();

            Assert.False(result);
        }

        [Fact]
        public void IsOccupied_InputIsRandom_ShouldReturnTrue()
        {
            var size = 3;
            var board = new Board(size);
            var player = new Player(size, 'X');
            var point = player.GetPoint();
            board.SetBoard(point, player.Symbol);
            var result = board.IsOccupied(point);

            Assert.True(result);
        }

        [Theory]
        //Horiz
        [InlineData(0, 0, 1, 0, 2, 0)]
        [InlineData(0, 1, 1, 1, 2, 1)]
        [InlineData(0, 2, 1, 2, 2, 2)]

        //Vert
        [InlineData(0, 0, 0, 1, 0, 2)]
        [InlineData(1, 0, 1, 1, 1, 2)]
        [InlineData(2, 0, 2, 1, 2, 2)]

        //Diagonal
        [InlineData(0, 0, 1, 1, 2, 2)]
        [InlineData(0, 2, 1, 1, 2, 0)]
        public void IsWinning_InputIsWinning_ShouldReturnTrue(int p0X, int p0Y, int p1X, int p1Y, int p2X, int p2Y)
        {
            var board = new Board(3);
            board.SetBoard(new Point(p0X, p0Y), 'X');
            board.SetBoard(new Point(p1X, p1Y), 'X');
            board.SetBoard(new Point(p2X, p2Y), 'X');

            var result = board.IsWinning('X');

            Assert.True(result);

        }

        [Theory]
        //Horiz
        [InlineData(0, 1, 1, 0, 2, 0)]
        [InlineData(0, 2, 1, 1, 2, 1)]
        [InlineData(0, 1, 1, 2, 2, 2)]

        //Vert
        [InlineData(0, 1, 0, 1, 0, 2)]
        [InlineData(1, 1, 1, 1, 1, 2)]
        [InlineData(2, 1, 2, 1, 2, 2)]

        //Diagonal
        [InlineData(0, 1, 1, 1, 2, 2)]
        [InlineData(0, 1, 1, 1, 2, 0)]
        public void IsWinning_InputIsNotWinning_ShouldReturnFalse(int p0X, int p0Y, int p1X, int p1Y, int p2X, int p2Y)
        {
            var board = new Board(3);
            board.SetBoard(new Point(p0X, p0Y), 'X');
            board.SetBoard(new Point(p1X, p1Y), 'X');
            board.SetBoard(new Point(p2X, p2Y), 'X');

            var result = board.IsWinning('X');

            Assert.False(result);

        }
    }
}