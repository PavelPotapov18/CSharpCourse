namespace App4._10;

class Program
{
    static void Main(string[] args)
    {
        const int n = 3;
        Random rnd = new Random();
        int[,] matrix = new int[n, n];
        // Запоняем матрицу значениями 0 или 1 в случайном порядке
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rnd.Next(0, 2);
                Console.Write($"{matrix[i,j]} ");
            }
            Console.WriteLine();
        }
        if(IsCorrectRow(matrix, n) || IsCorrectColumn(matrix, n) || IsCorrectMainDiag(matrix, n) || IsCorrectSecondDiag(matrix, n))
        {
            Console.WriteLine("Ура, крестики победили!!!");
        }
        else
        {
            Console.WriteLine("Увы, крестики проиграли!!!");
        }
    }
    public static bool IsCorrectRow(int[,] matrix, int n)
    {
        bool isCorrect = true;
        for(int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (matrix[i, j] != 1)
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        return isCorrect;
    }

    public static bool IsCorrectColumn(int[,] matrix, int n)
    {
        // Проверяем столбцы
        bool isCorrect = true;
        for(int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (matrix[j, i] != 1)
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        return isCorrect;
    }

    public static bool IsCorrectMainDiag(int[,] matrix, int n)
    {
        // Проверяем главную диагональ
        bool isCorrect = true;
        for(int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (i == j && matrix[i,j] == matrix[i + 1, j + 1] && matrix[i, j] == 1)
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        return isCorrect;
    }

    public static bool IsCorrectSecondDiag(int[,] matrix, int n)
    {
        // Проверяем побочную диагональ
        bool isCorrect = true;
        for(int i = 0; i < n - 1; i++)
        {
            for (int j = n - 1; j > 1; j--)
            {
                if (matrix[i,j] == matrix[i + 1, j - 1] && matrix[i, j] == 1)
                {
                    isCorrect = false;
                    break;
                }
            }
        }
        return isCorrect;
    }
}
