using System;
using System.Globalization;
using System.Numerics;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInicialInvestimento = Convert.ToDouble(Console.ReadLine());

            double taxaDeJuros = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            int anosDeInvestimento = Convert.ToInt32(Console.ReadLine());

            double montanteFinal = CalcularJurosSimples(valorInicialInvestimento, taxaDeJuros, anosDeInvestimento);

            Console.WriteLine(montanteFinal);
        }

        public static double CalcularJurosSimples(double valorInicialInvestimento, double taxaDeJuros, int anosDeInvestimento)
        {
            double juros = valorInicialInvestimento + (valorInicialInvestimento * taxaDeJuros * anosDeInvestimento);

            return juros;
        }
    }
}
