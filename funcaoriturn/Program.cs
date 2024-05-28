using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcaoriturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segudo numero");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação ");
            string operacao = Console.ReadLine();
            if (operacao == "+")
            {
                soma(operacao, n1, n2);
            Console.WriteLine("O resultado é: " + soma(operacao, n1, n2 ));
                Console.ReadKey();
            }


            else if (operacao == "-")
            {
                sub(operacao, n1, n2);
                Console.WriteLine("O resultado é: " + sub(operacao, n1, n2));
                Console.ReadKey();
            }

            else if (operacao == "*")
            {
                vezes(operacao, n1, n2);
                Console.WriteLine("O resultado é: " + vezes(operacao, n1, n2));
                Console.ReadKey();
            }
            else if (operacao == "/")
            {
                div(operacao, n1, n2);
                Console.WriteLine("O resultado é: " + div(operacao, n1, n2));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Algo deu errado");
            }
            
        }
        static double soma(string operacao,double n1, double n2 )
        {
                return n1 + n2;

        }
        static double sub(string operacao, double n1, double n2)
        {
            return n1 - n2;

        }
        static double vezes(string operacao, double n1, double n2)
        {
            return n1 * n2;

        }
        static double div(string operacao, double n1, double n2)
        {
            return n1 / n2;

        }



    }
    
}
