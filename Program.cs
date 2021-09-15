using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4,
            Potencia = 5, Raiz = 6, Sair = 7 }

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação" +
                    "\n5-Potenciação\n6-Raiz\n7-Sair");

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
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        exit = true;
                        break;
                }
                Console.Clear();

            }
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Digite primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte Enter para retornar ao menu");
            Console.ReadLine();

        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois números: ");
            Console.WriteLine("Digite primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte Enter para retornar ao menu");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números: ");
            Console.WriteLine("Digite primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a /(float) b;
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte Enter para retornar ao menu");
            Console.ReadLine();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois números: ");
            Console.WriteLine("Digite primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte Enter para retornar ao menu");
            Console.ReadLine();
        }

        static void Pot()
        {
            Console.WriteLine("Potêncial de dois números: ");
            Console.WriteLine("Digite a base: ");
            int BaseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(BaseNum, expo);                               
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte Enter para retornar ao menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de dois números: ");
            Console.WriteLine("Digite a número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte Enter para retornar ao menu");
            Console.ReadLine();
        }
    }
}
