using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace declaracionIfMejorada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // condicion ? primera expresión : segunda expresión;
            // la condicion solo puede ser un valor booleano, es decir, true o false
            // la expresion a ? b : c ? d : e
            // es evaluada como a ? b : (c ? d : e),
            // no como (a ? b : c) ? d : e

            // ejemplo con if tradicional
            int temperatura = -5;
            string estadoAgua;
            Console.WriteLine("---------- IF TRADICIONAL ------------------");
            if (temperatura < 0)
                estadoAgua = "Solida";
            else if (temperatura > 0 && temperatura < 100)
                estadoAgua = "Liquida";
            else
                estadoAgua = "Gaseosa";

            Console.WriteLine($"El estado del agua es: {estadoAgua}");

            // ejemplo con if mejorado
            Console.WriteLine("---------- IF MEJORADO ------------------");
            temperatura += 75;
            estadoAgua = temperatura < 0 ? "Solida" : temperatura > 0 && temperatura < 100 ? "Liquida" : "Gaseosa";

            Console.WriteLine($"El estado del agua es: {estadoAgua}");
            Console.Read();


        }

    }
}
