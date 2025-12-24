namespace App4._4;

class Program
{
    static void Main(string[] args)
    {
        int[] l = new int[10];
        Random rnd = new Random();
        for(int i = 0; i < l.Length; i++)
        {
            l[i] = rnd.Next(0, 11);
            Console.Write(l[i]);
            Console.Write(" ");
        }
        Console.WriteLine(" ");
        Array.Reverse(l);
        for(int i = 0; i < l.Length; i++)
        {
            Console.Write(l[i]);
            Console.Write(" ");
        }
    }
}
