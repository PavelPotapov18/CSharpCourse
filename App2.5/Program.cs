namespace App2._5;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        string result = a % 10 == 0 ? "Да" : "Нет";
        Console.WriteLine(result);
    }
}
