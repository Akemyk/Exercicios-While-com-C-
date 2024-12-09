using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioWhile
{
    internal class Exercicio10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int num = Convert.ToInt16(Console.ReadLine());

            int contador = 0;

            while (num > 0)
            {
                num /= 10;
                contador++;
            }
            Console.WriteLine("O número possui " +  contador);
        }
    }
}
