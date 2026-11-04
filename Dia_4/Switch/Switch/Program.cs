using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int autos = 6;

            switch (autos)
            {
                case 0:
                    Console.WriteLine("Sin pagar impuestos");
                    break;
                case 1:
                    Console.WriteLine("Pagar $15");
                    break;
                case 2:
                    Console.WriteLine("Pagar $30");
                    break;
                default:
                    Console.WriteLine("Pagar $15 por cada auto");
                    break;
            }
            // IF EN VEZ DE SWITCH
            if (autos == 0)
            {
                Console.WriteLine("Sin pagar impuestos");
            }
            else if (autos == 1)
            {
                Console.WriteLine("Pagar $15");
            }
            else if (autos == 2)
            {
                Console.WriteLine("Pagar $30");
            }
            else
            {
                Console.WriteLine("Pagar $15 por cada auto");
            }

            // switch con string

            string piedraPapelTijera = "Papel";

            switch (piedraPapelTijera)
            {
                case "Piedra":
                    Console.WriteLine("Gana piedra a tijera");
                    break;
                case "Papel":
                    Console.WriteLine("Gana papel a piedra");
                    break;
                case "Tijera":
                    Console.WriteLine("Gana tijera a papel");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }


            Console.Read();
        }
    }
}
