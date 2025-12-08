namespace App1._4;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int thousands = num / 1000;
        int hungreds = (num / 100) % 10;
        int dozens = (num / 10) % 10;
        int units = num  % 10;

        int newNum = thousands * 1000 + units * 100 + dozens * 10 + hungreds;
        Console.Write(newNum);
    }
}

