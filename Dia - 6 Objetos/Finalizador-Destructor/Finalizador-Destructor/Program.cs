using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalizador_Destructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Miembro nuevoMiembro = new Miembro();
            nuevoMiembro.Amigo(true);

            Console.Read();


        }
    }
}
