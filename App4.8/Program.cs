namespace App4._8;

class Program
{
    static void Main(string[] args)
    {
        const int n = 5;
        Random random = new Random();
        int[] l = new int[n];
        for(int i = 0; i < n; i++)
        {
            l[i] = random.Next(0, 11);
            Console.Write($"{l[i]} ");
        }

        int maxValue1 = 0;
        int maxIndex1 = 0;
        int maxValue2 = 0;
        int maxIndex2 = 0;


        for(int j = 0; j < n; j++)
        {
            if(l[j] > maxValue1)
            {
                maxValue1 = l[j];
                maxIndex1 = j;
            }
        }

        for(int k = 0; k < n; k++)
        {
            if(l[k] > maxValue2 && k != maxIndex1)
            {
                maxValue2 = l[k];
                maxIndex2 = k;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Первое максимальное значение в массиве находится под индексом {maxIndex1} и равняется {maxValue1}");
        Console.WriteLine($"Второе максимальное значение в массиве находится под индексом {maxIndex2} и равняется {maxValue2}");
    
    }
}
