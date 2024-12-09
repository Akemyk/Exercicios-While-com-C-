using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioWhile
{
    internal class Exercicio5
    {
        public static void Main(string[] args)
        {
            int num;

            do
            {
                Console.WriteLine("Digite um número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("O número é par");
                }
            }
            while (num % 2 == 1);
            {
                Console.WriteLine("Sucesso!");
            }

            
        }
    }
}
