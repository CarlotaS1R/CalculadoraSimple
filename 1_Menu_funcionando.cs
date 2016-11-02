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
        static void Main(string[] args)
        {
            char opcion;
            do
            {   // 1. mostar menu
                Menu();
                // 2. que el usuario introduzca opcion
                opcion = Console.ReadKey().KeyChar;
                Console.WriteLine("esto has pulsado: " + opcion);
            } while (opcion != '0');



            // PARA QUE LA CONSOLA PARE
            Console.ReadKey();

        }
    }
}
