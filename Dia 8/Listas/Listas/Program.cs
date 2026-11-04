using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nombres = new List<string>();
            var numeros = new List<int> { 1, 2, 3, 4, 5 };

            // Agregar elementos a la lista
            numeros.Add(6);

            // Eliminar elementos de la lista
            numeros.Remove(3);

            //RemoverAt elimina un elemento en una posición específica
            numeros.RemoveAt(0);

            //Asignar un valor a una posición específica
            numeros[0] = 10;
            var valor = numeros[0];

            //Eliminar todos los elementos de la lista
            numeros.Clear();

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }


            var numeros2 = new List<int> { 1, 2, 3, 4, 5 };
            for (int i = 0; i < numeros2.Count; i++)
            {
                Console.WriteLine("Cantidad de elementos: {0}", numeros2.Count);
                if (numeros2[i] == 2)
                {
                    numeros2.Add(6);
                }
                Console.WriteLine("Número: {0}", numeros2[i]);
                

            }


        }
    }
}
