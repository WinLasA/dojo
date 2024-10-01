namespace TicTacToe
{
    public interface IDisplay
    {
        void DrawBoard(char[,] board);
        void DrawText(string text);
    }
}
