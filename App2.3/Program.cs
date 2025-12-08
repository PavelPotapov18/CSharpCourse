namespace App2._3;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int maxValue = a;

        if(b >= maxValue)
        {
            maxValue = b;
        }
        if(c >= maxValue)
        {
            maxValue = c;
        }
        if(d >= maxValue)
        {
            maxValue = d;
        }
        Console.Write(maxValue);
    }
}
