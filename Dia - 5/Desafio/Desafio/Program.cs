using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            string ingreso="0";
            int numeroNotas = 0;
            int nota = 0;

            
            do{
                Console.WriteLine("Ingrese la nota: ");
                ingreso = Console.ReadLine();
                if (ingreso == "fin") break;

                else if (int.TryParse(ingreso,out nota) && (nota > 0 && nota < 11))
                {
                    numeroNotas++;
                    total += nota;
                }
                else
                {
                    Console.WriteLine("Nota no válida, ingrese una nota entre 1 y 10 o 'fin' para terminar.");
                    continue;
                }
               
            } while (ingreso != "fin") ;

            Console.WriteLine("El promedio de las notas es: " + ((double)total / (double)numeroNotas));
            
        }
    }
}
