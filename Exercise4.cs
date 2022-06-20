using System.Globalization;

public class Exercise4
{
    // 4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

    // SP – 67.836,43
    // RJ – R$36.678,66
    // MG – R$29.229,88
    // ES – R$27.165,48
    // Outros – R$19.849,53

    // Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.


    static double SP = 67836.43;
    static double RJ = 36678.66;
    static double MG = 29229.88;
    static double ES = 27165.48;
    static double Outros = 19849.53;
    static double FaturamentoTotal = SP + RJ + MG + ES + Outros;

    public static double PorcentagemDe(double valorDe, double valorTotal)
    {
        // valorTotal = 100         valorDe*100 = valorTotal*x
        // valorDe = x;             (valorDe*100) / valorTotal = x
        return (valorDe * 100) / valorTotal;
    }

    public static void Run()
    {
        Console.WriteLine("\nEXERCICIO 4 ---------------- ");
        Console.WriteLine($"FATURAMENTO SP: {SP.ToString("C", CultureInfo.CurrentCulture)} -- PORCENTAGEM DO FATURAMENTO TOTAL: {PorcentagemDe(SP, FaturamentoTotal).ToString("N2")}");
        Console.WriteLine($"FATURAMENTO RJ: {RJ.ToString("C", CultureInfo.CurrentCulture)} -- PORCENTAGEM DO FATURAMENTO TOTAL: {PorcentagemDe(RJ, FaturamentoTotal).ToString("N2")}");
        Console.WriteLine($"FATURAMENTO MG: {MG.ToString("C", CultureInfo.CurrentCulture)} -- PORCENTAGEM DO FATURAMENTO TOTAL: {PorcentagemDe(MG, FaturamentoTotal).ToString("N2")}");
        Console.WriteLine($"FATURAMENTO ES: {ES.ToString("C", CultureInfo.CurrentCulture)} -- PORCENTAGEM DO FATURAMENTO TOTAL: {PorcentagemDe(ES, FaturamentoTotal).ToString("N2")}");
        Console.WriteLine($"FATURAMENTO TOTAL: {FaturamentoTotal.ToString("C", CultureInfo.CurrentCulture)} -- PORCENTAGEM DO FATURAMENTO TOTAL: {PorcentagemDe(FaturamentoTotal, FaturamentoTotal).ToString("N2")}");
        Console.WriteLine($"FATURAMENTO Outros: {Outros.ToString("C", CultureInfo.CurrentCulture)} -- PORCENTAGEM DO FATURAMENTO TOTAL: {PorcentagemDe(Outros, FaturamentoTotal).ToString("N2")}");
    }
}