namespace App3._4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите показатель степени: ");
        int b = int.Parse(Console.ReadLine());
        // Проверка входных данных
        if(a <= 0 || b >= 0)
        {
            Console.WriteLine("Ошибка ввода данных!");
        }
        else
        {
            double result = 1;
            for (int i = 1; i <= b * -1; i++)
            {
                result *= a;
            }
            Console.Write(1 / result);
        }
    }
}
