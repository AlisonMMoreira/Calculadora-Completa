using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_completa_no_CMD
{
    internal class Program
    {

        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while(!escolheuSair)
            {
                //Exiba o menu
                Console.WriteLine("Seja ben vindo ao CALC, selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
//                Console.WriteLine(opcao);
//                Console.ReadLine();
                Console.Clear();
            }
            //
        }
        
        static void Soma()
        {
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é:  {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Subtracao()
        {
            {
                Console.WriteLine("Subtração de dois números: ");
                Console.WriteLine("Digite o primeiro número: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                int b = int.Parse(Console.ReadLine());
                int resultado = a - b;
                Console.WriteLine($"O resultado é:  {resultado}");
                Console.WriteLine("Aperte ENTER para voltar para o menu");
                Console.ReadLine();
            }
        }
        static void Divisao()
        {
            {
                Console.WriteLine("Divisão de dois números: ");
                Console.WriteLine("Digite o primeiro número: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                int b = int.Parse(Console.ReadLine());
                float resultado = (float)a / (float)b;
                Console.WriteLine($"O resultado é:  {resultado}");
                Console.WriteLine("Aperte ENTER para voltar para o menu");
                Console.ReadLine();
            }
        }
        static void Multiplicacao()
        {
            {
                Console.WriteLine("Multiplicação de dois númerosDivisão de dois números: ");
                Console.WriteLine("Digite o primeiro número: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                int b = int.Parse(Console.ReadLine());
                int resultado = a * b;
                Console.WriteLine($"O resultado é:  {resultado}");
                Console.WriteLine("Aperte ENTER para voltar para o menu");
                Console.ReadLine();
            }
        }
        static void Potencia()
        {
            {
                Console.WriteLine("Potência de um número: ");
                Console.WriteLine("Digite a base: ");
                int baseNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o expoente número: ");
                int expo = int.Parse(Console.ReadLine());
                int resultado = (int)Math.Pow(baseNum, expo);

                //float
                //double
                //decimal


                Console.WriteLine($"O resultado é:  {resultado}");
                Console.WriteLine("Aperte ENTER para voltar para o menu");
                Console.ReadLine();
            }
        }
        static void raiz()
        { 
                Console.WriteLine("Raiz de um número: ");
                Console.WriteLine("Digite o número: ");
                int a = int.Parse(Console.ReadLine());
                double resultado = Math.Sqrt(a);

                Console.WriteLine($"O resultado é:  {resultado}");
                Console.WriteLine("Aperte ENTER para voltar para o menu");
                Console.ReadLine();
        }
    }
}
