using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    internal class Caja
    {
        //ENCAPSULAMIENTO: Es un principio de la programación orientada a objetos que consiste en ocultar los detalles
        //internos de una clase y exponer solo lo necesario a través de métodos y propiedades. Esto permite proteger los datos y mantener la integridad del objeto.

        //Miembros variables
        private int largo;
        private int ancho;
        private int volumen;

        //miembro metodo
        //public void MuestraInfo()
        //{
        //    volumen = largo * Alto * ancho;
        //    Console.WriteLine("El largo de la caja es: " + largo);
        //    Console.WriteLine("El alto de la caja es: " + Alto);
        //    Console.WriteLine("El ancho de la caja es: " + ancho);
        //    Console.WriteLine("El volumen de la caja es: " + volumen);
        //}


        //constructor
        public Caja(int largo, int Alto, int ancho)
        {
            this.largo = largo;
            this.ancho = ancho;
            this.Alto = Alto;
        }


        public int Largo
        {
            get => largo;

            set => largo = value;

        }

        //propiedad autoimplementada
        public int Alto{ get; set; }

        // Prop + tab + tab para crear una propiedad autoimplementada
        public int MyProperty { get; set; }
        public int Ancho
        {
            get { return ancho; }
            set 
            { 
                if( value < 0)
                {
                    throw new ArgumentException("El ancho no puede ser negativo");
                }
                ancho = value; 
            }
        }

        public int Volumen
        {
            get { return Largo * Alto * Ancho; }
            set { volumen = value; }

        }

        public int SuperficieFrontal    
        {
            get { return (Largo * Alto); }
        }




    }
}
