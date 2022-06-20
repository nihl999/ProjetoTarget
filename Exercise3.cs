using System.Text.Json;
using System.Text.Json.Serialization;

public class Exercise3
{

    // 3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
    // • O menor valor de faturamento ocorrido em um dia do mês;
    // • O maior valor de faturamento ocorrido em um dia do mês;
    // • Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

    static string json = File.ReadAllText("resources/dados.json");
    static List<DayInvoicing> allInvoices = loadInvocingsJson();

    private class DayInvoicing
    {
        [JsonPropertyName("dia")]
        public int Day { get; set; }
        [JsonPropertyName("valor")]
        public double Value { get; set; }

        public override string ToString() { return $"Day: {Day} Value: {Value} \n"; }
    }

    private static List<DayInvoicing> loadInvocingsJson()
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
        var desserializedJson = JsonSerializer.Deserialize<List<DayInvoicing>>(json, options);
        desserializedJson.RemoveAll(day => day.Value == 0);
        return desserializedJson;
    }

    private static DayInvoicing getMinInvoiceDay()
    {
        DayInvoicing minInvoice = allInvoices[0];
        foreach (DayInvoicing dayInvoicing in allInvoices)
        {
            if (dayInvoicing == null) continue;
            if (dayInvoicing.Value == 0)
            {
                continue;
            }
            if (dayInvoicing.Value < minInvoice.Value) minInvoice = dayInvoicing;
        }
        return minInvoice;
    }

    private static DayInvoicing getMaxInvoiceDay()
    {
        DayInvoicing maxInvoice = allInvoices[0];
        foreach (DayInvoicing dayInvoicing in allInvoices)
        {
            if (dayInvoicing == null) continue;
            if (dayInvoicing.Value == 0)
            {
                continue;
            }
            if (dayInvoicing.Value > maxInvoice.Value) maxInvoice = dayInvoicing;
        }
        return maxInvoice;
    }

    private static double CalculateMonthAverage()
    {
        double monthTotal = 0;
        int businessDays = 0;
        foreach (DayInvoicing dayInvoicing in allInvoices)
        {
            monthTotal += dayInvoicing.Value;
            businessDays++;
        }
        return monthTotal / businessDays;
    }

    private static int CalculateDaysAboveMonthAverage()
    {
        double monthAverage = CalculateMonthAverage();
        int aboveDaysQuantity = 0;
        foreach (DayInvoicing dayInvoicing in allInvoices)
        {
            if (dayInvoicing.Value > monthAverage) aboveDaysQuantity++;
        }
        return aboveDaysQuantity;
    }

    public static void Run()
    {
        //allInvoices = loadInvocingsJson();
        Console.WriteLine("\nEXERCICIO 3 ---------------- ");
        Console.Write("Dia de menor faturamento: " + getMinInvoiceDay().ToString());
        Console.Write("Dia de maior faturamento: " + getMaxInvoiceDay().ToString());
        Console.WriteLine("Média de faturamento mensal: " + CalculateMonthAverage());
        Console.WriteLine("Quantidade de dias acima da média de faturamento mensal: " + CalculateDaysAboveMonthAverage());
    }
}

