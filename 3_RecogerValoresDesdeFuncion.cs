using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimple
{
    class Program
    {   
        static void Menu()
        {
            Console.WriteLine("MENU DE OPCIONES ..............");
            Console.WriteLine("1 ....  SUMA");
            Console.WriteLine("2 ....  RESTA");
            Console.WriteLine("3 ....  MULTIPLICACION");
            Console.WriteLine("4 ....  DIVISIÓN");
            Console.WriteLine("0 ..... SALIR");

        }
        static void RecogerOperandos(out double A, out double B)
        {
            string salida;
            // pedimos el primer operador
            Console.WriteLine("Escribe el primer operando:");
            salida = Console.ReadLine();
            double.TryParse(salida, out A);
            // pedimos el segundo operador
            Console.WriteLine("Escribe el segundo operando:");
            salida = Console.ReadLine();
            double.TryParse(salida, out B);
        }

        static void Main(string[] args)
        {
            char opcion;
            string salida;
            double operadorA, operadorB;
            do
            {   // 1. mostar menu
                Menu();
                // 2. que el usuario introduzca opcion
                opcion = Console.ReadKey().KeyChar;
                //Console.WriteLine("esto has pulsado: " + opcion);
                Console.Clear();

                switch (opcion)
                {
                    case '1':
                        RecogerOperandos(out operadorA, out operadorB);
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    default:
                        Console.WriteLine("Has introducido una opcion incorrecta.");
                        break;    
                }

            } while (opcion != '0');

            // PARA QUE LA CONSOLA PARE
            Console.ReadKey();

        }
    }
}
