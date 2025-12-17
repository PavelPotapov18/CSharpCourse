namespace App3._5;

class Program
{
    static void Main(string[] args)
    {
        bool isCorrect = false;
        const int a = 20;
        const int b = 60;
        while(!isCorrect)
        {
            Console.Write("Введите число: ");
            int input = int.Parse(Console.ReadLine());
            if(input >= a && input <= b)
            {
                isCorrect = true;
                Console.WriteLine("Программа успешно выполнена!!!");
            }
        }
        
    }
}

