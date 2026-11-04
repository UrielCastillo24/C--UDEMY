using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Multi_Dimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Manera de crear un array sin new string
            int[,] array_2dimensiones = 
            { 
                { 1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };


        //Array de 2 dimensiones
        string[,] matriz2D;


            string[,] array2D = new string[,]
            {
                {"A","B", "C"},
                {"D", "E", "F"},
                {"G", "H", "I"}
            };

            Console.WriteLine("El valor central es: {0}", array2D[1, 1]);


            //Array de 3 dimensiones
            string[,,] matriz3D;


            string[,,] array3D = new string[,,]
            {
                {
                    { "A","B", "C"},
                    {"D", "E", "F"},
                    {"G", "H", "I"}
                },
                {
                    { "J","K", "L"},
                    {"M", "N", "O"},
                    {"P", "Q", "R"}
                },
                {
                    {"S","T", "U"},
                    {"V", "W", "X"},
                    {"Y", "Z", "-"}
                }
            };

            Console.WriteLine("El valor central es: {0}", array3D[1, 1, 1]);


            string[,] nombres_2D = new string[3, 3]
                {
                    { "Juan", "María", "Pedro" },
                    { "Ana", "Luis", "Carmen" },
                    { "Diego", "Sofía", "Carlos" }
                };

            //Cambiar el valor de un elemento en la matriz  
            Console.WriteLine("El valor en la posición [0, 0] es: {0}", nombres_2D[0, 0]);
            nombres_2D[0, 0] = "José";
            Console.WriteLine("El valor en la posición [0, 0] es: {0}", nombres_2D[0, 0]);


            // PROPIEDAD 

            int dimension = nombres_2D.Rank; // Devuelve el número de dimensiones del array
            Console.WriteLine("El número de dimensiones del array es: {0}", dimension);

            

        }
    }
}
