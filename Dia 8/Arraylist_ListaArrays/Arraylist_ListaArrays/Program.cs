using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_ListaArrays
{
    internal class Program
    {
        //inmutable - limitado a un tipo
        int[] puntajes = new int[] { 90, 96, 88, 108 };
        static void Main(string[] args)
        {
            List<int> edades = new List<int>() { 24, 29, 31, 61, 64 };
            List<string> nombres = new List<string>() { "Dereck", "Danna", "S", "Rosalia", "Leonel" };

            List<float> numeros = new List<float>() { 1.2f, 8.5f, 2.3f, 3.4f, 9.81f, 4.5f, 5.6f };

            edades.Add(90);

            foreach (int edad in edades)
            {
                Console.WriteLine(edad);
            }

            //RemoveRange(4, 2); - elimina 2 elementos a partir de la posición 3
            numeros.RemoveRange(5, 1);
            numeros.Sort();
            numeros.Remove(3.4f);
            //RemoveAt(3) - elimina el elemento en la posición 3
            //RemoveAll(x => x < 5) - elimina todos los elementos menores a 5
            bool existe = numeros.Contains(9.81f); // devuelve true si el elemento existe en la lista

            foreach (float numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("El numero tiene el valor 9.81? " + existe);

            int indice = numeros.FindIndex(x => x == 9.81f); // devuelve el índice del primer elemento que cumple la condición
            Console.WriteLine("El índice del número 9.81 es: " + indice);

            numeros.RemoveAt(indice); // elimina el elemento en la posición 3
            numeros.ForEach(x => Console.WriteLine(x)); // imprime todos los elementos de la lista

            System.Collections.ArrayList arrayl = new System.Collections.ArrayList(); // lista de tipo object, puede contener cualquier tipo de dato

            arrayl.Add(7);
            arrayl.Add("Hola");
            arrayl.Add(3.14);

            arrayl.Add(new numero { valor = 4 });

            foreach (var item in arrayl)
            {
                Console.WriteLine(item);
            }
        }
    }

    class numero
    {
        public int valor { get; set; }

        public override string ToString()
        {
            return valor.ToString();
        }

    }
}
