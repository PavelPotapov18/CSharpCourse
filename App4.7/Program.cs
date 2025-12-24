namespace App4._7;

class Program
{
    static void Main(string[] args)
    {
        const int rows = 10;
        const int columns = 5;
        Random random = new Random();
        int[,] l = new int[rows, columns];
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                l[i, j] = random.Next(0,11);
                Console.Write($"{l[i,j], 4}");
                
            }
            Console.WriteLine(" ");
            
        }

        for(int i = 0; i < rows; i++)
        {
            int maxValue = 0;
            for(int j = 0; j < columns; j++)
            {
                if(l[i, j] > maxValue)
                {
                    maxValue = l[i, j];
                }
            }
            Console.WriteLine($"Максимальное значение в строке {i+1} - {maxValue}");
        }
    }

}
