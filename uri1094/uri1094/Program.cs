using System;

namespace URI1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int QuantidadeDeCasos = int.Parse(Console.ReadLine());

            int coelho = 0;
            int ratos = 0;
            int sapos = 0;


            for (int i = 1; i <= QuantidadeDeCasos; i++) 
            {
                string[] vet = Console.ReadLine().Split(' ');
                int Cobaias = int.Parse(vet[0]);
                string Animal = vet[1];

                switch (Animal)
                {
                    case "C":
                        coelho += Cobaias;
                        break;

                    case "R":
                        ratos += Cobaias;
                        break;

                    case "S":
                        sapos += Cobaias;
                        break;
                }
            }
            int total = coelho + ratos + sapos;

            double porcentagemCoelho = (double)coelho / total * 100;
            double porcentagemRatos = (double)ratos / total * 100;
            double porcentagemSapos = (double)sapos / total * 100;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de Coelhos: " + porcentagemCoelho.ToString("F2") + " %");
            Console.WriteLine("Percentual de Ratos: " + porcentagemRatos.ToString("F2") + " %");
            Console.WriteLine("Percentual de Sapos: " + porcentagemSapos.ToString("F2") + " %");
        }
    }
}