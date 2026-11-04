using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysIrregulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar un arreglo irregular de 3 filas
            int[][] irregular = new int[3][];

            //Asignar el tamaño de cada fila
            irregular[0] = new int[5];
            irregular[1] = new int[3];
            irregular[2] = new int[2];

            //Asignar valores a cada elemento del arreglo irregular
            irregular[0] = new int[] { 18, 42, 34, 49, 5 }; 
            irregular[1] = new int[] { 67, 78, 84 };
            irregular[2] = new int[] { 91, 10 };

            //Otro ejemplo de arreglo irregular
            int[][] irregular2 = new int[][]
                {
                    new int[] { 11, 22, 33 },
                    new int[] { 44, 55 },
                    new int[] { 66, 77, 88, 99 }
                };

            //Imprimir los valores del arreglo irregular
            Console.WriteLine("Arreglo irregular {0}:", irregular2[0][2]);

            //Imprimir los valores del arreglo irregular
            for (int i = 0; i < irregular2.Length; i++)
            {
                Console.Write("Array "+ i + ": { ");
                for (int j = 0; j < irregular2[i].Length; j++)
                {
                    Console.Write(irregular2[i][j] + " , ");
                }
                Console.WriteLine("}");
                Console.WriteLine();
            }


        }
    }
}
