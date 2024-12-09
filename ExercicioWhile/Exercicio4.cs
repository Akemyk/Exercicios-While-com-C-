using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioWhile
{
    internal class Exercicio4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para a multiplicação");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<=10; i++)
            {
                int resul = num * i;
                Console.WriteLine($"{num} x {i } = {resul}");
            }
        }
    }
}
