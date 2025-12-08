using System.Numerics;

namespace App2._2;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int maxValue = a;
        if(b >= maxValue)
        {
            maxValue = b;
        }
        if(c >= maxValue)
        {
            maxValue = c;
        }
        Console.Write(maxValue);
    }
}
