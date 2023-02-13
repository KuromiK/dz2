using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] plum = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    plum[i, j] = rand.Next(0, 100);
                    Console.Write(plum[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[] lip = new int[1];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (plum[i, j] % 3 == 0)
                    {
                        lip[k] = plum[i, j];
                        k++;
                        Array.Resize(ref lip, k + 1);
                    }
                }
            }
            for (int i = 0; i < k; i++)
                Console.Write(lip[i] + "  ");
            Console.ReadKey();
        }
    }
}
