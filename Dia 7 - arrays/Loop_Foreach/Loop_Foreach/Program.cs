using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            //for (int j = 0; j < nums.Length; j++) 
            //{ 
            //    Console.WriteLine("El valor del indice {0}: {1}", j, nums[j]);
            //}

            foreach (int i in nums)
            {
                Console.WriteLine("El valor del indice {0}: {1}", i, nums[i]);

            }

            string[] amigos =
            {
                "Mon",
                "JUCA",
                "Fernanda",
                "Sam",
                "Limon"
            };

            foreach (string amigo in amigos)
            {
                Console.WriteLine("El nombre del amigo es: {0}", amigo);
            }

        }
    }
}
