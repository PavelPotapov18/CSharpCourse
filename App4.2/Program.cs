namespace App4._2;

class Program
{
    static void Main(string[] args)
    {
        int[] l = new int[10];
        Random rnd = new Random();
        int negativeCount = 0;
        int zeroCount = 0;
        int positiveCount = 0;
        for(int i = 0; i < l.Length; i++)
        {
            l[i] = rnd.Next(-20, 21);
            if(l[i] == 0)
            {
                zeroCount++;
            }
            else if(l[i] > 1)
            {
                positiveCount++;
            }
            else if(l[i] < 1)
            {
                negativeCount++;
            }
        }
        Console.WriteLine($"Количество положительных чисел в массиве: {positiveCount}");
        Console.WriteLine($"Количество отрицательных чисел в массиве: {negativeCount}");
        Console.WriteLine($"Количество нулей в массиве: {zeroCount}");
    }
}
