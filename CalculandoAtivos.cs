//## Resolvido por Foqsz ##//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        { 
            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 
            string[] valoresMercadoStr = Console.ReadLine().Split(',');

            double[] valoresMercado = Array.ConvertAll(valoresMercadoStr, s => double.Parse(s, CultureInfo.InvariantCulture));
 
            double valorTotalInvestido = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 
            string[] alocacoesMinimasStr = Console.ReadLine().Split(',');

            double[] alocacoesMinimas = Array.ConvertAll(alocacoesMinimasStr, s => double.Parse(s, CultureInfo.InvariantCulture));
 
            string[] alocacoesMaximasStr = Console.ReadLine().Split(',');

            double[] alocacoesMaximas = Array.ConvertAll(alocacoesMaximasStr, s => double.Parse(s, CultureInfo.InvariantCulture));
 
            double totalMercado = 0;
            for (int i = 0; i < N; i++)
            { 
                totalMercado += valoresMercado[i];
            }
 
            double[] alocacoes = new double[N];
            for (int i = 0; i < N; i++)
            { 
                double proporcional = (valoresMercado[i] / totalMercado) * valorTotalInvestido;

                alocacoes[i] = Math.Max(alocacoesMinimas[i], Math.Min(alocacoesMaximas[i], proporcional)); 
            }
 
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(alocacoes[i].ToString("F2", CultureInfo.InvariantCulture)); 
            }
        }
    }
}
