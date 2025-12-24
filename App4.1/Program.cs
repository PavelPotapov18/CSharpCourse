namespace App4._1;

class Program
{
    static void Main(string[] args)
    {
        int[] l = new int[10];
        Random rnd = new Random();
        int evenCount = 0;
        int oddCount = 0;
        for(int i = 0; i < l.Length; i++)
        {
            l[i] = rnd.Next(0, 101);
            if(l[i] % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }
        string answer = evenCount > oddCount ? "Четных чисел больше" : "Нечетных чисел больше";
        Console.WriteLine(answer);
    }
}
