using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioWhile
{
    internal class Exercicio13
    {
        public static void Main(string[] args)
        {
            int num;
            int par = 0;

            do
            {
                Console.WriteLine("Digite um número inteiro ou 0 para sair");
                num = Convert.ToInt16(Console.ReadLine());

                if (num != 0 && num % 2 == 0)
                {
                    par += num;
                }
            } while (num != 0);

            Console.WriteLine("Soma é "+par);
        }
    }
}
