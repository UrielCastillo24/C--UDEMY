using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esAdmin = false;
            bool estaRegistrado = true;
            string nombreUsuario = "";
            Console.WriteLine("Ingrese nombre de usuario");
            nombreUsuario = Console.ReadLine();

            if (estaRegistrado && nombreUsuario != "")
            {
                Console.WriteLine("Bienvenido usuario registrado");
                
                Console.WriteLine("user: " + nombreUsuario);
                if (nombreUsuario.Equals("Admin")) // COMPARAR STRINGS CON METODO EQUALS
                {
                    Console.WriteLine("ADMIN USER");
                }
            }

            if(esAdmin || estaRegistrado)
            {
                Console.WriteLine("Estas logueado");
            }

            Console.Read();
        }
    }
}
