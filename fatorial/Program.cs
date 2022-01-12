using System;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, fat = 1, i; 
            Console.WriteLine("Cálculo Fatorial\n\n");
            Console.WriteLine("Digite um número para ver seu fatorial:");
            numero = Convert.ToInt32(Console.ReadLine());
            i = numero;

            while(i>=1)

            {
                fat = fat * 1;
                i--;
            }
            Console.WriteLine("Fatorial é {0}", fat.ToString());
        }
    }
}
