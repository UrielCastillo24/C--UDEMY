using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Arrays_Irregulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] amigosFamilia = new string[][]
            {
                new string[]{ "Miguel", "Sandra"},
                new string[]{ "Franco", "Claudia", "Oscar", "Leon"},
                new string[]{ "Andres", "Mónica", "Lucía"}
            };

            Console.WriteLine("Hola {0}, quiero presentarte a {1}", amigosFamilia[0][0], amigosFamilia[1][0]);
            Console.WriteLine("Hola {0}, quiero presentarte a {1}", amigosFamilia[1][1], amigosFamilia[2][2]);
            Console.WriteLine("Hola {0}, quiero presentarte a {1}", amigosFamilia[1][3], amigosFamilia[0][1]);
            Console.WriteLine("Hola {0}, quiero presentarte a {1}", amigosFamilia[2][0], amigosFamilia[1][2]);

            Console.WriteLine("-------------------------------------------------------------------------------------------------------");

            string[][] automovilesFamilia = new string[][]
            {
                new string[]{ "Pontiac", "G3", "2007", "Gris"},
                new string[]{ "Honda", "Accord", "2009", "Verde"},
                new string[]{ "Chrysler", "Voyager", "1998", "Dorado"},
                new string[]{ "Chrysler", "Shadow", "2005", "Gris"},
                new string[]{ "Chevrolet", "Chevy", "2003", "Telmex"},
                new string[]{ "Volkswagen", "Vocho", "2000", "Blanco"},
            };

            Console.WriteLine("La familia Castillo Ramirez tuvo {0} automóviles", automovilesFamilia.Length);
            Console.WriteLine("Tuvo un {0} {1} del año {2} de color {3}", automovilesFamilia[0][0], automovilesFamilia[0][1], automovilesFamilia[0][2], automovilesFamilia[0][3]);
            Console.WriteLine("Tuvo un {0} {1} del año {2} de color {3}", automovilesFamilia[1][0], automovilesFamilia[1][1], automovilesFamilia[1][2], automovilesFamilia[1][3]);
            Console.WriteLine("Tuvo un {0} {1} del año {2} de color {3}", automovilesFamilia[2][0], automovilesFamilia[2][1], automovilesFamilia[2][2], automovilesFamilia[2][3]);
            Console.WriteLine("Tuvo un {0} {1} del año {2} de color {3}", automovilesFamilia[3][0], automovilesFamilia[3][1], automovilesFamilia[3][2], automovilesFamilia[3][3]);
            Console.WriteLine("Tuvo un {0} {1} del año {2} de color {3}", automovilesFamilia[4][0], automovilesFamilia[4][1], automovilesFamilia[4][2], automovilesFamilia[4][3]);
            Console.WriteLine("Tuvo un {0} {1} del año {2} de color {3}", automovilesFamilia[5][0], automovilesFamilia[5][1], automovilesFamilia[5][2], automovilesFamilia[5][3]);
        }
    }
}
