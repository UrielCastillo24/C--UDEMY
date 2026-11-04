using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaraciones_If_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la temperatura: ");
            string input = Console.ReadLine();
            Console.WriteLine(input);
            
            int temperatura = Int32.Parse(input);   //convertir el string ingresado a entero           

            if (temperatura < 15)
            {
                Console.WriteLine("La temperatura es {0}, es menor a 15", temperatura);
            }
            else if(temperatura == 15)
            {
                Console.WriteLine("Hay 15 grados de temperatura");
            }
            else if (temperatura > 15)
            {
                Console.WriteLine("La temperatura es {0}, es mayor a 15", temperatura);
            }
        }
    }
}
