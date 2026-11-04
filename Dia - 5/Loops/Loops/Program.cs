using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LOOP for
            for (int i = 1; i < 20; i+=2)
            {
                Console.WriteLine("El numero: " + i + " es impar");
            }

            // loop do while
            int contador = 0;
            do
            {
                contador++;
                Console.WriteLine("Do: " + contador);

            } while (contador < 6);


            // loop while
            while (contador > 0)
            {
                contador--;
                if (contador == 3) break;
                Console.WriteLine("While: " + contador);
            }


            //loop foreach
            string[] arreglo = { "Dereck", "Uriel", "Castillo", "Ramirez" };
            string[] arreglo2 = { "nombre: ", "segundo nombre: ", "apellido: ", "segundo apellido: " };

            int index = 0;
            foreach (string item in arreglo)
            {
                Console.WriteLine(arreglo2[index] + item);
                index++;
            }

            int suma = 0;
            for (int i = 0; i < 50; i += 2)
            {
                suma = suma + i;
            }
            Console.WriteLine(suma);

            int numero = 5;
            int factorial = 1;

            for (int i = 1; i <= 5; i++)
            {
                factorial = factorial * i;
            }


            Console.WriteLine("factorial: " + factorial);
        }
    }
}
