namespace App2._6;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        string result = a % 2 == 0 ? "Да" : "Нет";
        Console.WriteLine(result);
    }
}
