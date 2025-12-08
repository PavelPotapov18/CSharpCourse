namespace App2._4;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int medianValue = a;

        if((b >= a && b <= c) || (b >= c && b <= a))
        {
            medianValue = b;
        }
        if((c >= a && c <= b) || (c >= b && c <= a))
        {
            medianValue = c;
        }
        Console.Write(medianValue);
    }
}
