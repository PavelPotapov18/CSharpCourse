namespace App4._9;

class Program
{
    static void Main(string[] args)
    {
        const int rows = 4;
        const int cols = 5;
        int[,] matrix = new int[rows, cols];
        

        int value = 1;
        int top = 0, bottom = rows - 1;
        int left = 0, right = cols - 1;
        
        while (value <= rows * cols)
        {
            // Верхняя строка (слева направо)
            for (int i = left; i <= right && value <= rows * cols; i++)
            {
                matrix[top, i] = value++;
            }
            top++;
            
            // Правый столбец (сверху вниз)
            for (int i = top; i <= bottom && value <= rows * cols; i++)
            {
                matrix[i, right] = value++;
            }
            right--;
            
            // Нижняя строка (справа налево)
            for (int i = right; i >= left && value <= rows * cols; i--)
            {
                matrix[bottom, i] = value++;
            }
            bottom--;
            
            // Левый столбец (снизу вверх)
            for (int i = bottom; i >= top && value <= rows * cols; i--)
            {
                matrix[i, left] = value++;
            }
            left++;
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}
