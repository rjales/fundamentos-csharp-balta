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
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-------------------");
            Console.Write("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            double result = v1 + v2;

            Console.WriteLine($"o resultado da soma é: {result}");

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            double result = v1 - v2;

            Console.WriteLine($"o resultado da subtração é: {result}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            double result = v1 * v2;

            Console.WriteLine($"o resultado da multiplicação é: {result}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            double result = v1 / v2;

            Console.WriteLine($"o resultado da divisão é: {result}");

            Console.ReadKey();
            Menu();
        }
    }
}