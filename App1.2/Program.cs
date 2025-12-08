using System.Data;

namespace App1._2;

class Program
{
    static void Main(string[] args)
    {
        double degrees = double.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());
        

        degrees += (double)minutes / 60;
        degrees += (double)seconds / 3600;

        double radians = degrees  * Math.PI / 180; 

        Console.Write(radians);
    }
}
