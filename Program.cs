using System.Text.Json;
using System.Text.Json.Serialization;

public class Exercise3
{
    static string json = File.ReadAllText("resources/dados.json");

    private class DayInvoicing
    {
        [JsonPropertyName("dia")]
        public int Day { get; set; }
        [JsonPropertyName("valor")]
        public double Value { get; set; }
    }

    private static DayInvoicing[] loadInvocingsJson()
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
        var desserializedJson = JsonSerializer.Deserialize<DayInvoicing[]>(json, options);
        return desserializedJson;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(json);
    }
}

public class Exercise2
{
    static bool isInFibonacci(int number)
    {
        if (number == 0 || number == 1)
            return true;
        else
        {
            // Bibliografia: https://en.wikipedia.org/wiki/Fibonacci_number#Identification
            double positiveFormula = ((5 * (number * number)) + 4);
            double negativeFormula = ((5 * (number * number)) - 4);
            return Math.Sqrt(positiveFormula) % 1 == 0 || Math.Sqrt(negativeFormula) % 1 == 0;
        }
    }
}