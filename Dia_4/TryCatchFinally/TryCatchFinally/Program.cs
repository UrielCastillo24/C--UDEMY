using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ingrese un numero: ");
            string ValorIngresado = Console.ReadLine();


            int num1 = 5;
            int num2 = 0;
            int resultado;

            

            try
            {
                //int VAL = int.Parse(ValorIngresado);
                resultado = num1 / num2;
            }
            catch (FormatException)
            {
                Console.WriteLine("El valor ingresado es incorrecto");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Valor ingresado es demasiado largo o corto");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Valor vacio o nulo ingresado");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("no se puede dividir en cero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            finally 
            {
                Console.WriteLine("CODIGO LLEGO AL FINAL");
            }

            Console.ReadKey();
        }
    }
}
