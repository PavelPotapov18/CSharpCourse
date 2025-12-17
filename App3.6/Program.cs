namespace App3._6;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        double a = 2;
        int i = 0;
        while(true)
        {
            double b = Math.Pow(a, i);
            if(b == num)
            {
                Console.WriteLine("Введенное число является степенью числа 2");
                break;
            }
            else if(b < num)
            {
                i++;
                continue;
            }
            else if(b > num)
            {
                Console.WriteLine("Введенное число не является степенью числа 2");
                break;
            }
        }
    }
}
