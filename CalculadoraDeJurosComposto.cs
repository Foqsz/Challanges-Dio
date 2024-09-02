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

            double montanteFinal = CalcularaJurosComposto(valorInicialInvestimento, taxaDeJuros, anosDeInvestimento);

            Console.WriteLine(montanteFinal.ToString(CultureInfo.InvariantCulture));
        }

        public static double CalcularaJurosComposto(double valorInicialInvestimento, double taxaDeJuros, int anosDeInvestimento)
        { 
            double juros = valorInicialInvestimento * Math.Pow(1 + taxaDeJuros, anosDeInvestimento);
             
            return juros;
        }
    }
}
