using TicTacToe;

//var game = new Game(3);
//game.Run();

var result = MakeComplement("ATTGC");
Console.WriteLine(result);

 static string MakeComplement(string dna)
{
    string result = "";
    foreach (var c in dna)
    {
        switch (c)
        {
            case 'G':
                result += 'C';
                break;
            case 'C':
                result += 'G';
                break;
            case 'A':
                result += 'T'; 
                break;
            case 'T':
                result += 'A';
                break;
        }
    }
    return result;
}