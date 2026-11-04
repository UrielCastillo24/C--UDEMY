using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tateti_Dia_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int jugador = 2;
            int ingreso = 0;
            bool ingresoValido = true;
            

            do
            {
                if (jugador == 2)
                {
                    jugador = 1;
                    ponerX_O(jugador, ingreso);
                }
                else if (jugador == 1)
                {
                    jugador = 2;
                    ponerX_O(jugador, ingreso);
                }

                CrearTablero();

                //Verificar si hay un ganador
                #region
                char [] cadasigno = { 'X', '0' };

                foreach(char signo in cadasigno)
                {
                    if (((tableroJuego[0, 0] == signo) && (tableroJuego[0, 1] == signo) && (tableroJuego[0, 2] == signo)) ||
                        ((tableroJuego[1, 0] == signo) && (tableroJuego[1, 1] == signo) && (tableroJuego[1, 2] == signo)) ||
                        ((tableroJuego[2, 0] == signo) && (tableroJuego[2, 1] == signo) && (tableroJuego[2, 2] == signo)) ||
                        ((tableroJuego[0, 0] == signo) && (tableroJuego[1, 0] == signo) && (tableroJuego[2, 0] == signo)) ||
                        ((tableroJuego[0, 1] == signo) && (tableroJuego[1, 1] == signo) && (tableroJuego[2, 1] == signo)) ||
                        ((tableroJuego[0, 2] == signo) && (tableroJuego[1, 2] == signo) && (tableroJuego[2, 2] == signo)) ||
                        ((tableroJuego[0, 0] == signo) && (tableroJuego[1, 1] == signo) && (tableroJuego[2, 2] == signo)) ||
                        ((tableroJuego[0, 2] == signo) && (tableroJuego[1, 1] == signo) && (tableroJuego[2, 0] == signo)))
                    {
                        if(signo == 'X')
                        {
                            jugador = 2;
                        }
                        else
                        {
                            jugador = 1;
                        }
                        Console.WriteLine("Jugador {0} ha ganado", jugador);
                        Console.WriteLine("Presione cualquier tecla para reiniciar el juego");
                        Console.Read();
                        ingreso=0;
                        ReiniciarTablero();
                        break;
                    }
                    else if(turnos == 10)
                    { 
                        Console.WriteLine("Empate");
                        Console.WriteLine("Presione cualquier tecla para reiniciar el juego");
                        Console.Read();
                        ingreso = 0;
                        ReiniciarTablero();
                        break;
                    }
                }
            

                #endregion

                //Codigo que valida el ingreso del jugador y que la casilla este disponible
                #region
                do
                {
                    Console.WriteLine("Jugador {0} ingrese un numero de casilla del 1 al 9 para colocar su ficha: ", jugador);

                    try
                    {
                        ingreso = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Ingrese un numero");
                    }

                    if((ingreso == 1) && (tableroJuego[0, 0] == '1'))
                        ingresoValido = true;
                    else if ((ingreso == 2) && (tableroJuego[0, 1] == '2'))
                        ingresoValido = true;
                    else if ((ingreso == 3) && (tableroJuego[0, 2] == '3'))
                        ingresoValido = true;
                    else if ((ingreso == 4) && (tableroJuego[1, 0] == '4'))
                        ingresoValido = true;
                    else if ((ingreso == 5) && (tableroJuego[1, 1] == '5'))
                        ingresoValido = true;
                    else if ((ingreso == 6) && (tableroJuego[1, 2] == '6'))
                        ingresoValido = true;
                    else if ((ingreso == 7) && (tableroJuego[2, 0] == '7'))
                        ingresoValido = true;
                    else if ((ingreso == 8) && (tableroJuego[2, 1] == '8'))
                        ingresoValido = true;
                    else if ((ingreso == 9) && (tableroJuego[2, 2] == '9'))
                        ingresoValido = true;
                    else 
                        ingresoValido = false;
                        Console.WriteLine("Ingrese otro numero.");

                } while (!ingresoValido);
                #endregion

            } while (true);



        }

        //Metodo identificador de jugador
        public static void ponerX_O(int jugador, int ingreso)
        {
            char simbolo = jugador == 1 ? 'X' : '0';

            switch (ingreso)
            {
                case 1: tableroJuego[0, 0] = simbolo; break;
                case 2: tableroJuego[0, 1] = simbolo; break;
                case 3: tableroJuego[0, 2] = simbolo; break;
                case 4: tableroJuego[1, 0] = simbolo; break;
                case 5: tableroJuego[1, 1] = simbolo; break;
                case 6: tableroJuego[1, 2] = simbolo; break;
                case 7: tableroJuego[2, 0] = simbolo; break;
                case 8: tableroJuego[2, 1] = simbolo; break;
                case 9: tableroJuego[2, 2] = simbolo; break;
            }


        }

        //Array bidimensional para representar el tablero de juego inicial
        static char[,] tableroJuegoInicial =
        {
            {'1','2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };

        static int turnos = 0;

        public static void ReiniciarTablero()
        {
            Console.Clear();
            tableroJuego = tableroJuegoInicial;
            turnos = 0;
            CrearTablero();
        }

        //Array bidimensional para representar el tablero de juego
        static char[,] tableroJuego =
        {
            {'1','2', '3'},
            {'4', '5', '6'},
            {'7', '8', '9'}
        };
        // Metodo para crear el tablero de juego
        public static void CrearTablero()
        {
            Console.Clear();
            Console.WriteLine("          |             |");
            Console.WriteLine("    {0}     |      {1}      |     {2}", tableroJuego[0, 0], tableroJuego[0, 1], tableroJuego[0, 2]);
            Console.WriteLine("          |             |");
            Console.WriteLine("__________|_____________|__________");
            Console.WriteLine("          |             |");
            Console.WriteLine("    {0}     |      {1}      |     {2}", tableroJuego[1, 0], tableroJuego[1, 1], tableroJuego[1, 2]);
            Console.WriteLine("          |             |");
            Console.WriteLine("__________|_____________|__________");
            Console.WriteLine("          |             |");
            Console.WriteLine("    {0}     |      {1}      |     {2}", tableroJuego[2, 0], tableroJuego[2, 1], tableroJuego[2, 2]);
            Console.WriteLine("          |             |");
            turnos++;
        }


    }
}
