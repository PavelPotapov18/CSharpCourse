namespace App2._9;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        string result = (a <= -10 || a >= 10) ? "Да" : "Нет";
        Console.WriteLine(result);
    }
}
