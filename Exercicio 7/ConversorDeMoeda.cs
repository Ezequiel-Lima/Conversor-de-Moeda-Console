namespace Exercicio_7
{
    static public class ConversorDeMoeda
    {
        //Conversão da moeda com + 6% de IOF
        static public double Conversao(double cotacao, double dolares)
        {
            double valor = cotacao * dolares;
            double resultado = ((valor * 6) / 100) + valor;
            return resultado;
        }
    }
}
