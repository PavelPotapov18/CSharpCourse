namespace App3._7;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        // double a = 10;
        int i = 0;
        while(true)
        {
            double b = Math.Pow(10, i);
            if((int)(num / b) == 0)
            {
                Console.WriteLine($"{i}");
                break;
            }
            else
            {
                i++;
                continue;
            }
        }
    }
}
