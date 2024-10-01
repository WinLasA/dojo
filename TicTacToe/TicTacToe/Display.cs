namespace TicTacToe
{
    public class Display : IDisplay
    {
        public void DrawBoard(char[,] board)
        {
            Console.Clear();
            for (var y = 0; y < board.GetLength(0); y++)
            {
                for (var x = 0; x < board.GetLength(1); x++)
                {
                    Console.Write(board[y, x] + "|");
                }
                Console.WriteLine();
                for (var i = 0; i < board.GetLength(0); i++)
                {
                    Console.Write("-+");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void DrawText(string text)
        {
            Console.WriteLine(text);
        }
    }
}
