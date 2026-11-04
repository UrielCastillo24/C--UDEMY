using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caja caja = new Caja(5, 4, 3);
            Console.WriteLine("El volumen de la caja es: " + caja.Volumen);
            // caja.Largo = 5;
            // caja.Alto = 3;
            // caja.Ancho = 4;
            // caja.MuestraInfo();

            Console.WriteLine("La superficie frontal de la caja es: " + caja.SuperficieFrontal);
        }


    }
}
