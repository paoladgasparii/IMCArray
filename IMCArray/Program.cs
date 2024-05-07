using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[5];
            double[] peso = new double[5];
            double[] altura = new double[5];
            double[] imc = new double[5];
            double acimadopeso = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe o nome: ");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Informe o peso: ");
                peso[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe a altura: ");
                altura[i] = double.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("Resultados:");

            for (int i = 0; i < 5; i++)
            {
                imc[i] = peso[i] / (altura[i] * altura[i]);

                Console.WriteLine("Nome: " + nome[i]);
                Console.WriteLine("Peso: " + peso[i]);
                Console.WriteLine("Altura: " + altura[i]);
                Console.WriteLine("IMC: " + imc[i]);

                if (imc[i] <= 18.5)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (imc[i] <= 24.9)
                {
                    Console.WriteLine("Peso ideal");
                }
                else if (imc[i] <= 29.9)
                {
                    Console.WriteLine("Levemente acima do peso");
                    acimadopeso++;
                }
                else if (imc[i] <= 34.9)
                {
                    Console.WriteLine("Obesidade grau I");
                    acimadopeso++;
                }
                else if (imc[i] <= 39.9)
                {
                    Console.WriteLine("Obesidade grau II(severa)");
                    acimadopeso++;
                }
                else
                {
                    Console.WriteLine("Obesidade grau III (mórbida)");
                    acimadopeso++;
                }

                Console.WriteLine();
            }

            double porcacimadopeso = (double)acimadopeso / 5 * 100;
            Console.WriteLine("Porcentagem de pessoas acima do peso: " + porcacimadopeso);

            Console.ReadKey();
        }
    }
}
