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
            Console.Clear();
            Console.WriteLine("MENU DE OPCIONES ..............");
            Console.WriteLine("1 ....  SUMA");
            Console.WriteLine("2 ....  RESTA");
            Console.WriteLine("3 ....  MULTIPLICACION");
            Console.WriteLine("4 ....  DIVISIÓN");
            Console.WriteLine("0 ..... SALIR");

        }
        static void MenuMultiplicacion()
        {
            Console.Clear();
            Console.WriteLine("MENU DE MULTIPLICACION ..............");
            Console.WriteLine("1 ....  TABLA MULTIPLICAR");
            Console.WriteLine("2 ....  MULTIPLICAR");

        }



        static void RecogerOperando(out double A)
        {
            string salida;
            bool correcto;
            // pedimos el primer operador
            do
            {   Console.WriteLine("Escribe operando:");
                salida = Console.ReadLine();
                correcto = double.TryParse(salida, out A);
                if (!correcto) Console.WriteLine("ERROR: El dato introducido no es un número, vuelve a intentarlo...");
            }  while (!correcto);
       
        }
        static void Sumar(double operadorA)
        {   // declarar acumulativo sumaTotal
            double sumaTotal = operadorA;
            double operadorB;
            string salida;
            bool pusoUnCero = false;

            //Hacer {
            do
            {   RecogerOperando(out operadorB);
                if (operadorB != 0)
                { //    SumaTotal = sumaTotal + operadorB;
                    sumaTotal += operadorB;
                    //   Mostrar la suma Parcial
                    Console.WriteLine("Suma: " + sumaTotal);
                    //        fin si
                }
                else pusoUnCero = true;
            } while (!pusoUnCero);  //} Mientras operadorB != 0
        }
        static void Main(string[] args)
        {
            char opcion;
            double operadorA, operadorB;

            do
            {   // 1. mostar menu
                Menu();
                // 2. que el usuario introduzca opcion
                opcion = Console.ReadKey().KeyChar;
                Console.Clear();
                if (opcion != '0')
                {
                    switch (opcion)
                    {
                        case '1': //Suma
                            RecogerOperando(out operadorA);
                            Sumar(operadorA);
                            break;
                        case '2': //Resta
                            RecogerOperando(out operadorA);
                            RecogerOperando(out operadorB);
                            Console.WriteLine("el Total es: " + (operadorA - operadorB));
                            break;
                        case '3': //Multiplicar
                            RecogerOperando(out operadorA);
                            MenuMultiplicacion();
                            if (Console.ReadKey().KeyChar == '1')
                            {
                                Console.Clear();
                                for (int i=1;i<=10; i++)
                                {
                                    double resultado = operadorA * i;
                                    Console.WriteLine(resultado);
                                }
                            }
                            else
                            {
                                RecogerOperando(out operadorB);
                                Console.WriteLine("el Total es: " + (operadorA * operadorB));
                            }
                            Console.WriteLine("pulse para continuar...");
                            Console.ReadLine();    
                            break;

                        case '4': //Dividir

                            RecogerOperando(out operadorA);
                            do
                            {
                                RecogerOperando(out operadorB);
                                if(operadorB==0)
                                {
                                    Console.WriteLine("Debe introducir un divisor diferente a 0");
                                }
                            }
                            while (operadorB == 0);
                            Console.WriteLine("el Total es: " + (operadorA / operadorB));
                            Console.WriteLine("el Resto es: " + (operadorA % operadorB));
                            Console.WriteLine("pulse para continuar...");
                            Console.ReadLine();
                            break;
                    }
                }

            } while (opcion != '0');
        }
    }
}
