namespace App3._3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите показатель степени: ");
        int b = int.Parse(Console.ReadLine());
        // Проверка входных данных
        if(a <= 0 || b <= 0)
        {
            Console.WriteLine("Ошибка ввода данных!");
        }
        else
        {
            double result = 1;
            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }
            Console.Write(result);
        }
    }
}
