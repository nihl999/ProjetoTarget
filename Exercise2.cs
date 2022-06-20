public class Exercise2
{
    // 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo 
    // valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),
    // escreva um programa na linguagem que desejar onde, informado um número, 
    // ele calcule a sequência de Fibonacci e retorne uma mensagem 
    // avisando se o número informado pertence ou não a sequência.

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

    public static void Run()
    {
        Console.WriteLine("\nEXERCICIO 2 ---------------- ");
        Console.WriteLine($"\n 1: {1} esta na sequencia fibonacci? {(isInFibonacci(1) ? "Sim" : "Não")}");
        Console.WriteLine($"\n 1: {2} esta na sequencia fibonacci? {(isInFibonacci(2) ? "Sim" : "Não")}");
        Console.WriteLine($"\n 1: {3} esta na sequencia fibonacci? {(isInFibonacci(3) ? "Sim" : "Não")}");
        Console.WriteLine($"\n 1: {4} esta na sequencia fibonacci? {(isInFibonacci(4) ? "Sim" : "Não")}");
        Console.WriteLine($"\n 1: {12} esta na sequencia fibonacci? {(isInFibonacci(12) ? "Sim" : "Não")}");
        Console.WriteLine($"\n 1: {5} esta na sequencia fibonacci? {(isInFibonacci(5) ? "Sim" : "Não")}");
        Console.WriteLine($"\n 1: {7} esta na sequencia fibonacci? {(isInFibonacci(7) ? "Sim" : "Não")}");
    }
}