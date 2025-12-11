namespace App3._2;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double result = 1;
        for (int i = 2; i <= n; i++)
        {
            result += 1 / (double)i;
        }
        Console.Write(result);
    }
}