using System; 
class Programa
{
    static void Main(string[] args)
    {
        Console.Write("Diggite um numero:");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite outro numero:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double resultad = num + num2;
        Console.WriteLine($"A soma dos numeros é {resultad}");
        Console.ReadKey();

    }
}