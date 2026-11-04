using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysComoParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] calificaciones = new int[] {10, 9, 8, 7, 6, 5, 8};
            double promedioResultado = ObtenerPromedio(calificaciones);

            foreach(int calificacion in calificaciones)
            {
                Console.WriteLine("Calificación: {0}", calificacion);
            }

            Console.WriteLine("El promedio es: {0}", promedioResultado);

            Console.WriteLine("-----------------------------------------");

            int[] saldos = {1100, 200, 800, 1400, 500 };
            Credito(saldos);

            foreach(int saldo in saldos)
            {
                Console.WriteLine("Saldo: {0}", saldo);
            }

        }

        static double ObtenerPromedio(int[] arrayDePuntajes)
        {
            int Cantidad = arrayDePuntajes.Length;
            double promedio;
            int suma = 0;

            for( int i = 0; i < Cantidad; i++)
            {
                suma += arrayDePuntajes[i];
            }

            promedio = (double)suma / Cantidad; // Casting to double to avoid integer division
            return promedio;
        }

        static void Credito(int [] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                x[i] += 200;
            }
        }
    }
}
