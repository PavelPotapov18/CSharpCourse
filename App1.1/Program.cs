namespace App1._1;

class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = a;
        a = c;
        c = b;
        b = d;
        Console.WriteLine($"{a} {b} {c}");
    }
}
