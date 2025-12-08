namespace App2._10;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string end = "домов";
        switch((n % 100) % 10)
        {
            case 1:
                if(n % 100 == 11)
                    break;
                end = "дом";
                break;
            case 2:
            case 3:
            case 4:
                if(n % 100 > 10 && n % 100 < 15)
                    break;
                end = "дома";
                break;
        }
        Console.WriteLine($"Мы построили {n} {end}.");
    }
}
