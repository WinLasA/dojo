namespace TicTacToe
{
    public class Game
    {
        private readonly IDisplay _display;
        private readonly Player _playerA;
        private readonly Player _playerB;
        private readonly Board _board;
        public Game(int size)
        {
            _board = new Board(size);
            _display = new Display();
            _playerA = new Player(size, 'X');
            _playerB = new Player(size, 'O');
        }

        public void Run()
        {
            //Game loop
            while (!_board.IsFull())
            {
                //PlayerA is playing
                _playerA.Play(_board);
                _display.DrawBoard(_board.GetBoard());

                if (_board.IsWinning(_playerA.Symbol))
                {
                    _display.DrawText($"Player {_playerA.Symbol} wins!");
                    return;
                }

                Console.ReadKey();

                if (_board.IsFull()) continue;
                
                //PlayerB is playing
                _playerB.Play(_board);
                _display.DrawBoard(_board.GetBoard());

                if (_board.IsWinning(_playerB.Symbol) )
                {
                    _display.DrawText($"Player {_playerB.Symbol} wins!");
                    return;
                }

                Console.ReadKey();
            }
        }
    }
}
