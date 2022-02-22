using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Digite a opção que deseja: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair da Aplicação");

            Console.WriteLine(".................");
            Console.WriteLine("Selecione uma opção: ");
            short result = (short.Parse(Console.ReadLine()));

            switch (result)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite um numero: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero: ");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 + n2;
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite um numero: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = n1 - n2;
            Console.WriteLine("O resultado da subtração é " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro numero: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = n1 / n2;
            Console.WriteLine($"o resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro numero: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = n1 * n2;
            Console.WriteLine($"O resultado da Multiplicação é {resultado}");
            Console.ReadKey();
            Menu();

        }
    }
}