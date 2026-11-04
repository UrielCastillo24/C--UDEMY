using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar un arraylist
            ArrayList miArrayList = new ArrayList();

            //ArrayList determinado
            ArrayList miArrayList2 = new ArrayList(100);

            //Agregar elementos al arraylist
            miArrayList.Add(25);

            miArrayList.Add("Hola");

            miArrayList.Add(3.14);

            miArrayList.Add(true);

            miArrayList.Add(new DateTime(2024, 6, 1));


            //Eliminar elementos del arraylist
            miArrayList.Remove(100);

            //Eliminar elemento en un indice especifico
            miArrayList.RemoveAt(4);

            //Recorrer el arraylist
            foreach (var item in miArrayList)
            {
                Console.WriteLine(item);
            }

            double suma = 0;

            //Recorrer el arraylist con foreach OBJECT
            foreach (object item in miArrayList)
            { 
                if(item is int)
                {
                    suma += Convert.ToDouble(item);
                }
                else if(item is double)
                {
                    suma += (double)item;
                }
                else if (item is string)
                {
                    Console.WriteLine($"El elemento es un string: {item}");
                }
                else
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine(suma);
            }

            //Numero de elementos en el arraylist
            Console.WriteLine($"Numero de elementos: {miArrayList.Count}");




        }
    }
}
