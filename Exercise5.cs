using System.Text;

public class Exercise5
{
    public static string ReverseString(string toReverseString)
    {
        StringBuilder sb = new StringBuilder(toReverseString);
        //Começa invertendo o primeiro e ultimo caracter, e continua com segundo/penultimo...
        for (int i = 0; i < toReverseString.Length / 2; i++)
        {
            char TempCharEndIt = toReverseString[toReverseString.Length - i - 1];
            char TempCharStartIt = toReverseString[i];
            sb[i] = TempCharEndIt;
            sb[toReverseString.Length - i - 1] = TempCharStartIt;
        }
        return sb.ToString();
    }

    public static void Run()
    {
        Console.WriteLine("\nEXERCICIO 5 ---------------- ");
        Console.WriteLine($"BANANA: {ReverseString("BANANA")}");
        Console.WriteLine($"MAÇA: {ReverseString("MAÇA")}");
        Console.WriteLine($"CARLOS: {ReverseString("CARLOS")}");
        Console.WriteLine($"TARGET: {ReverseString("TARGET")}");
    }
}