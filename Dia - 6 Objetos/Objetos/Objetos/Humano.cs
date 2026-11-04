using System;

namespace Objetos
{
    internal class Humano
    {
        //crear un miembro variable
        public string nombre;
        public string apellido;
        private string colorOjos;
        private int edad;

        //Constructor por defecto
        public Humano()
        {
            Console.WriteLine("Constructor por defecto");
        }


        // Constructor con parámetros
        public Humano(string name, string lastname)
        {
            this.nombre = name;
            this.apellido = lastname;
        }


        // MIEMBRO CONSTRUCTOR -> Inicializan el estado de un objeto cuando se crea una instancia de la clase.
        // Se llama automáticamente cuando se crea un objeto y no tiene un tipo de retorno, ni siquiera void.
        // El constructor tiene el mismo nombre que la clase y puede tener parámetros para inicializar los atributos del objeto.
        public Humano(string miPrimerNombre, string apellido, string colorOjos, int edad)
        {
            nombre = miPrimerNombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
            this.edad = edad;   
        }


        //Miembro método
        public void presentarme()
        {
            if (edad != 0)
            { 
                if (edad == 1 && nombre != null && apellido != null && colorOjos != null)
                {
                    Console.WriteLine("Hola, soy el Ing. {0} {1} y tengo {2} año. Mis ojos son {3}", nombre, apellido, edad, colorOjos);
                }
                else
                {
                    Console.WriteLine("Hola, soy el Ing. {0} {1} y tengo {2} años. Mis ojos son {3}", nombre, apellido, edad, colorOjos);
                }
            }
            else if(edad == 1 && nombre != null && apellido != null)
            {
                Console.WriteLine("Hola, soy {0} {1} ", nombre, apellido);
            }
            else
            {
                Console.WriteLine("Ingresa datos válidos para poder presentarte");
            }


                
        }

    }
}