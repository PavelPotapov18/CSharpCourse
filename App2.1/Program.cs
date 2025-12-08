namespace App2._1;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        string result = a == b ? "=" : a > b ? ">" : "<";
        Console.WriteLine($"a {result} b");
    }
}
