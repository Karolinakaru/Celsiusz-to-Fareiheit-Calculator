internal class Program
{
    private static void Main(string[] args)
    {
        double C, F;
        Console.WriteLine("Wpisz stopnie Celsjusza");
        C = double.Parse(Console.ReadLine());
        // program wyliczy stopnie Farenheita na podstawie podanych stopni Celsjusza
        //Program will calculate Fahrenheit degrees based on the provided Celsius degree
        F = 32 + (9d / 5 * C);
        Console.Write("Jest to: {0} stopni Fahrenheita.", F);
        Console.ReadKey();
    }
}