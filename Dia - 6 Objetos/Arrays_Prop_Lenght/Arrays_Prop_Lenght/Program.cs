using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Prop_Lenght
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primera forma de declarar un arreglo
            int[] calificaciones = new int[5];
            calificaciones[0] = 10;  
            calificaciones[1] = 8;  
            calificaciones[2] = 9;  
            calificaciones[3] = 7;  
            calificaciones[4] = 8;

            //Modificar las calificaciones
            Console.WriteLine("Ingrese la primera calificación: ");
            string ingreso = Console.ReadLine();
            calificaciones[0] = int.Parse(ingreso);

            Console.WriteLine("Primera calificación: {0}", calificaciones[0]);
            Console.WriteLine("Segunda calificación: {0}", calificaciones[1]);
            Console.WriteLine("Tercera calificación: {0}", calificaciones[2]);
            Console.WriteLine("Cuarta calificación: {0}", calificaciones[3]);
            Console.WriteLine("Quinta calificación: {0}", calificaciones[4]);


            //Segunda forma de declarar un arreglo
            int[] edades = { 18, 20, 22, 24, 26 };
            Console.WriteLine("Edad 1: {0}", edades[0]);
            Console.WriteLine("Edad 2: {0}", edades[1]);
            Console.WriteLine("Edad 3: {0}", edades[2]);
            Console.WriteLine("Edad 4: {0}", edades[3]);
            Console.WriteLine("Edad 5: {0}", edades[4]);

            //Tercera forma de declarar un arreglo
            int[] faltas = new int[] { 1, 2, 3, 4, 5, 3 };   
            Console.WriteLine("Falta 1: {0}", faltas[0]);
            Console.WriteLine("Falta 2: {0}", faltas[1]);
            Console.WriteLine("Falta 3: {0}", faltas[2]);
            Console.WriteLine("Falta 4: {0}", faltas[3]);
            Console.WriteLine("Falta 5: {0}", faltas[4]);


            //Propiedad Length
            Console.WriteLine("Número de faltas: {0}", faltas.Length);

            Console.WriteLine("La última calificación registrada es {0}", calificaciones[calificaciones.Length - 1]);
        }
    }
    
}
