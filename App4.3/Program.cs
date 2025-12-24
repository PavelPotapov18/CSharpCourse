namespace App4._3;

class Program
{
    static void Main(string[] args)
    {
        int[] l = new int[10];
        Random rnd = new Random();
        for(int i = 0; i < l.Length; i++)
        {
            l[i] = rnd.Next(0, 51);
            Console.WriteLine(l[i]);
        }

        int maxValue = l.Max();
        int maxValueIndex = l.IndexOf(maxValue);

        int minValue = l.Min();
        int minValueIndex = l.IndexOf(minValue);

        Console.WriteLine($"Максимальное значение в массиве - {maxValue}. Расположено под индексом {maxValueIndex}");
        Console.WriteLine($"Минимальное значение в массиве - {minValue}. Расположено под индексом {minValueIndex}");
    }
}
