using System;
using System.Globalization;

namespace Currencies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // decimal valor = 10392.25m;

            // var culture = CultureInfo.CreateSpecificCulture("pt-BR");

            Console.Write("Digite o primeiro número: ");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal result = num1 + num2;
            // result.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR"));

            Console.WriteLine(result.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));

            // Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
        }
    }
}