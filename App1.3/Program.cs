namespace App1._3;

class Program
{
    static void Main(string[] args)
    {
        int lenInches = int.Parse(Console.ReadLine());
        double lenMetric = lenInches * 2.54;
        int lenMeters  = (int)lenMetric / 100;
        double lenSantimeters = lenMetric - lenMeters;
        double lenMillimeters = lenSantimeters % 1 * 10;
        Console.WriteLine($"{lenMeters} м {(int)lenSantimeters} см {Math.Round(lenMillimeters, 1)} мм");
    }
}
