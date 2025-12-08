namespace App2._7;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        string result = (a / 10 != 0  && a / 10 <= 9) ? "Да" : "Нет";
        Console.WriteLine(result);
    }
}
