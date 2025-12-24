namespace App4._5;

class Program
{
    static void Main(string[] args)
    {
        int[] l = new int[10];
        Random rnd = new Random();
        for(int i = 0; i < l.Length; i++)
        {
            l[i] = rnd.Next(-50, 51);
        }
        int[] l1 = l[0..5];
        int[] l2 = l[5..^0];

        // Array.Sort(l1);
        // Array.Sort(l2);
        // Array.Reverse(l2); 

        for(int i = 0; i < l1.Length - 1; i++)
        {
            for(int j = i + 1; j < l1.Length; j++)
            {
                if(l1[i] > l1[j])
                {
                    int temp  = l1[i];
                    l1[i] = l1[j];
                    l1[j] = temp;
                }
            }
        }

        for(int i = 0; i < l2.Length - 1; i++)
        {
            for(int j = i + 1; j < l2.Length; j++)
            {
                if(l2[i] < l2[j])
                {
                    int temp  = l2[i];
                    l2[i] = l2[j];
                    l2[j] = temp;
                }
            }
        }

        for(int i = 0; i < l1.Length; i++)
        {
            Console.Write($"{l1[i]} ");
        }

        for(int j = 0; j < l2.Length; j++)
        {
            Console.Write($"{l2[j]} ");
        }
    }
}
