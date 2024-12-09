using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioWhile
{
    internal class Exercicio11
    {
        public static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Digite um número entre 1 e 100");
                num = Convert.ToInt16(Console.ReadLine());
            } while (num < 1 || num > 100);

            Console.WriteLine("Entrada válida");

        }
    }
}
