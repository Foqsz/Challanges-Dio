using System; 

namespace Course
{ 

    internal class Program
    {
        static bool VerificarAtributo(string atributo, int valorMinimo, int valorMaximo, int valorAtributo)
        {
            if (valorAtributo >= valorMinimo && valorAtributo <= valorMaximo)
            { 
                return true;
            }
            else
            { 
                return false;
            }

        }
        static void Main(string[] args)
        {
            string atributo = Console.ReadLine();   

            int valorMinimo = int.Parse(Console.ReadLine());

            int valorMaximo = int.Parse(Console.ReadLine());

            int valorAtributo = int.Parse(Console.ReadLine());

            VerificarAtributo(atributo, valorMinimo, valorMaximo, valorAtributo);
             
            if (VerificarAtributo(atributo, valorMinimo, valorMaximo, valorAtributo))
            {
                Console.WriteLine("O valor do atributo está dentro do intervalo especificado");
            }
            else
            {
                Console.WriteLine("O valor do atributo está fora do intervalo especificado");
            }
        }
    }
}
