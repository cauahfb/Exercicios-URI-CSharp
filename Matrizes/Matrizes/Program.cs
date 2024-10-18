using System;
using System.ComponentModel;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int LC = int.Parse(Console.ReadLine());

            int[,] matriz = new int[LC, LC];

            for (int i = 0; i < LC; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < LC; j++)
                {
                    matriz[i,j] = int.Parse(s[j]);
                }
            }

            for (int l = 0; l < LC; l++)
            {
                int maior = 0;
                for (int k = 0; k < LC; k++)
                {
                    if (matriz[l, k] > maior)
                    {
                        maior = matriz[l, k];
                    }
                    
                }
                Console.WriteLine(maior);
            }
        }
    }
}