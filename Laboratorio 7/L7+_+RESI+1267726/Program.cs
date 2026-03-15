using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7___RESI_1267726
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___Problema 1 - Mostrar numeros del 1 al 20___");
            string nom = "Rodrigo Esteban Sian Ic";
            int carnet = 1267726, indice = 1;
            Console.WriteLine("Nombre: " + nom + ", carnet: " + carnet);
            while (indice <= 20)
            {
                if (indice % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(indice);
                indice = indice + 1;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("___Problema 2 - DO-WHILE___");
            int divi = 1;
            Console.WriteLine("Ingresa un numero positivo: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numeros divisibles: ");
            do
            {
                if (num % divi == 0)
                {
                    if (divi != num)
                    {
                        Console.Write(divi);
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.Write(divi);
                    }
                }
                divi++;


            } while (divi <= num);
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("___Problema 3 - Serie de Fibonacci___");
            Console.WriteLine("Ingresa un numero positivo para delimitar tu serie de Fibonacci: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            Console.WriteLine("Serie de Fibonacci:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int siguiente = a + b;
                a = b;
                b = siguiente;
            }
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("___Problema 4 - Tablas de multiplicar___");
            for (int i = 0; i <= 11; i++)
            {
                Console.WriteLine("Tabla del " + (i + 1));
                for (int j = 0; j < 10; j++)
                {
                    int res = (i + 1) * (j + 1);
                    Console.WriteLine((i + 1) + " * " + (j + 1) + " = " + res);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
