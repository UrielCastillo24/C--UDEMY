using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroComoString = "128";
            int valorParseado;

            bool exito = int.TryParse(numeroComoString, out valorParseado);
            //el valor booleano de retorno sera true si Parse es posible

            if (exito) {
                Console.WriteLine("Parsing exitoso: "+valorParseado);
            }
            else
            {
                Console.WriteLine("´Parsing fallido") ;
            }

            string numeroComoString2 = "23.6";
            float valorParseado2;

            bool exito2 = float.TryParse(numeroComoString2, out valorParseado2);
            //el valor booleano de retorno sera true si Parse es posible

            if (exito2)
            {
                Console.WriteLine("Parsing exitoso: " + valorParseado2);
            }
            else
            {
                Console.WriteLine("´Parsing fallido");
            }


            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;


            Console.WriteLine("Ingresa la temperatura: ");
            string input = Console.ReadLine();
            Console.WriteLine(input);

            int temperatura = Int32.Parse(input);   //convertir el string ingresado a entero           
            int numero;
            int numtemperatura;

            if (int.TryParse(temperatura, out numero)
            {
                numtemperatura = temperatura;
            }
            else
            {
                numtemperatura = 0;
                Console.WriteLine("El valor no es valida, default 0")
            }

            if (temperatura < 10)
            {
                Console.WriteLine("La temperatura es {0}, es menor a 10", temperatura);
            }
            else if (temperatura == 10)
            {
                Console.WriteLine("Hay 10 grados de temperatura");
            }
            else if (temperatura > 10)
            {
                Console.WriteLine("La temperatura es {0}, es mayor a 10", temperatura);
            }




        }
    }
}
