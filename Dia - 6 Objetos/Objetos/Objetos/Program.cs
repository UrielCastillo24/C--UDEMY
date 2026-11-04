using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Humano humanoBasico = new Humano("Juan", "Cardzoza");
            humanoBasico.presentarme();


            // Una calse es un plano de un objeto, es decir, es la definición de un objeto. Un objeto es una instancia de una clase.
            // A partir de estas se pueden crear objetos en base a su definición, es decir, a partir de la clase.
            // Una clase va a estar compuesta por propiedades y métodos

            //crear una instancia de la clase Humano
            Humano dereck = new Humano("Dereck Uriel", "Castillo Ramirez", "Cafes", 24);

            dereck.presentarme();

            Humano leonel = new Humano("Leonel", "Castillo", "Cafes", 64);

            leonel.presentarme();

            Humano abigail = new Humano("Danna", "Castillo", "Cafes", 1);

            abigail.presentarme();



        }
    }
}
