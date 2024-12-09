using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExercicioWhile
{
    internal class Exercicio12
    {
        public static void Main(string[] args)
        {
            int num;
            int par = 0;
            int impar = 0;

          
            do
                
            {
                Console.WriteLine("Digite um número inteiro");
                num = Convert.ToInt16(Console.ReadLine());


                if (num != 0)
                {
                    if(num % 2 == 0)
                    {
                        par++;
                    }
                    else
                    {
                        impar++;
                    }
                }
            }while (num != 0);
            Console.WriteLine("Voce digitou " +par+ "números pares e "+impar+ "ímpares");
        }
    }
}

