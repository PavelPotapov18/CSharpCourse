using System.Diagnostics;

namespace App4._6;

class Program
{
    static void Main(string[] args)
    {
        const int n = 5;
        int[,] l = new int[n,n];
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if((i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0))
                {
                    l[i,j] = 1;
                }
                else
                {
                    l[i,j] = 0;
                }
            
                Console.Write($"{l[i,j]} ");
                
            }
            Console.WriteLine(" ");
        }
    }
}
