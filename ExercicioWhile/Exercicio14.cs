using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioWhile
{
    internal class Exercicio14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int num = Convert.ToInt16(Console.ReadLine());

            int potencia = 1;
            int resultado = num*potencia; ;

            while (resultado <= 1000)
            {
                Console.WriteLine("O resultado é "+resultado);

                potencia *= 2;

                resultado=num*potencia;
            }
        }
    }
}
