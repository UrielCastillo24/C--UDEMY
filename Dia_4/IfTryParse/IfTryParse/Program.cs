using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la temperatura: ");
            string input = Console.ReadLine();
            Console.WriteLine(input);

            int temperatura = Int32.Parse(input);   //convertir el string ingresado a entero           
            int numero;
            int numtemperatura;

            if (int.TryParse(input, out numero))
            {
                numtemperatura = temperatura;
            }
            else
            {
                numtemperatura = 0;
                Console.WriteLine("El valor no es valida, default 0");
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
