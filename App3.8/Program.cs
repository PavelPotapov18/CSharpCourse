namespace App3._8;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int num_length = GetNumberLength(num);
        Console.WriteLine(num_length);
        double new_num = num % 10 * Math.Pow(10, num_length - 1);
        for(int i = num_length - 1; i > 0; i--)
        {
            int a = (int)(num / Math.Pow(10, i));
            new_num += a * Math.Pow(10, num_length - i - 1);
            num = (int)(num % Math.Pow(10, i));
        }
        Console.WriteLine(new_num.ToString());
    }

    static int GetNumberLength(int number)
    {
        int i = 0;
        while(true)
        {
            double b = Math.Pow(10, i);
            if((int)(number / b) == 0)
            {
                return i;
            }
            else
            {
                i++;
                continue;
            }
        }
    }
}
