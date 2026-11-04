using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioIF_2
{
    internal class Program
    {
        static int record = 300;
        static string recordPersona = "Michael Phelps";

        static void Main(string[] args)
        {
            revisarRecord(100, "Rafa Nadal");
            revisarRecord(250, "Lionel Messi");
            revisarRecord(350, "Usain Bolt");
        }

        public static void revisarRecord(int puntaje, string jugador)
        {
            if(puntaje > record)
            {
                Console.WriteLine("Nuevo record! " + jugador + " ha superado el record de " + recordPersona + " con un puntaje de " + puntaje);
                record = puntaje;
                recordPersona = jugador;
            }
            else
            {
                Console.WriteLine("No se ha superado el record de " + recordPersona + " con un puntaje de " + record);
            }
        }
    }
}
