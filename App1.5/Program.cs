namespace App1._5;

class Program
{
    static void Main(string[] args)
    {
        double len = Convert.ToDouble(Console.ReadLine());
        Console.Write(Math.Round(len, 0, MidpointRounding.ToPositiveInfinity));
    }
}