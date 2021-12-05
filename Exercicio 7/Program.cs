using System;

namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conversão da moeda com + 6% de IOF
            Console.WriteLine("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você vai comprar?");
            double dolares = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nValor a ser pago em reais = " +
                $"{ConversorDeMoeda.Conversao(cotacao, dolares).ToString("F2")}");  

            Console.WriteLine("\nPressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
