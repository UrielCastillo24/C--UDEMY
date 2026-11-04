using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioIfMejorado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperaturaIngresada = 0;
            string mensajeTemperatura = string.Empty;
            string valorIngresado = string.Empty;

            Console.WriteLine("Ingrese la temperatura: ");
            valorIngresado = Console.ReadLine();

            bool integerValido = int.TryParse(valorIngresado, out temperaturaIngresada);

            //Operador ternario

            if (integerValido)
            {
                mensajeTemperatura = temperaturaIngresada <= 15 ? "Hace mucho frio" : (temperaturaIngresada >= 16 && temperaturaIngresada <= 28) ? "Hace un buen clima" : (temperaturaIngresada > 28) ? "Hace mucho calor" : "";
                Console.WriteLine(mensajeTemperatura);
            }
            else
            {
                Console.WriteLine("Valor ingresado no es una temperatura valida");
            }

        }
    }
}
