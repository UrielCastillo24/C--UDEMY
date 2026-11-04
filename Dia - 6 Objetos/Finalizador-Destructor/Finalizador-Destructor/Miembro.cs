using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalizador_Destructor
{
    internal class Miembro
    {
        //Miembros campos privado
        private string nombrePersona;
        private string tituloTrabajo;
        private int salario;

        //Miembros - Campo publico
        public int edad;

        //Miembros - Propiedades
        public string TituloTrabajo 
        {
            get
            {
                return tituloTrabajo;
            }
            set
            {
                tituloTrabajo = value;
            }
        }

        //Metodos Privados
        private void CompartirInfoPrivada()
        {
            Console.WriteLine("Nombre: {0}", nombrePersona);
            Console.WriteLine("Titulo de trabajo: {0}", tituloTrabajo);
            Console.WriteLine("Salario: {0}", salario);
            Console.WriteLine("Edad: {0}", edad);
        }

        //Miembros - Metodos Publicos
        public void Amigo(bool esAmigo)
        {
            if (esAmigo)
            {
                CompartirInfoPrivada();
            }
            else
            {
                Console.WriteLine("No comparto mi información privada, mi nombre es {0} y tengo {1} años", nombrePersona, edad);
            }
        }

        //Miembros - Constructor
        public Miembro()
        {
            
            nombrePersona = "Dereck";
            tituloTrabajo = "Ingeniero de Software";
            salario = 50000;
            edad = 24;

            Console.WriteLine("Objeto Creado");
        }

        //Miembros - Destructor - Finalizador
        ~Miembro()
        {
            Console.WriteLine("Objeto destruido");
            Debug.WriteLine("Objeto destruido");
        }


    }
}
