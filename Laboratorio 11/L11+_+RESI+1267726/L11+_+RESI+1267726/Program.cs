using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11___RESI_1267726
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Ejercicio2();
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Ejercicio3();
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Ejercicio4();
            Console.WriteLine("\nPrograma finalizado. Presione una tecla para salir...");
            Console.ReadKey();
        }

        static void Ejercicio1()
        {
            Console.WriteLine("\tDETECCIÓN DE PALÍNDROMOS");

            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine().ToLower();

            bool esPalindromo = true;

            for (int i = 0; i < palabra.Length / 2; i++)
            {
                if (palabra[i] != palabra[palabra.Length - 1 - i])
                {
                    esPalindromo = false;
                    break;
                }
            }

            Console.WriteLine("Resultado: " + esPalindromo);
        }
        static void Ejercicio2()
        {
            string[] espanol = { "rojo", "azul", "amarillo", "blanco", "verde" };
            string[] ingles = { "red", "blue", "yellow", "white", "green" };
            string[] italiano = { "rosso", "blu", "giallo", "bianco", "verde" };

            int opcion = 0;

            while (opcion != 2)
            {
                Console.WriteLine("\tTRADUCCIÓN DE PALABRAS");
                Console.WriteLine("1. Practicar lección");
                Console.WriteLine("2. Terminar lección");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Ingrese una palabra en español: ");
                    string palabra = Console.ReadLine().ToLower();

                    bool encontrada = false;

                    for (int i = 0; i < espanol.Length; i++)
                    {
                        if (palabra == espanol[i])
                        {
                            Console.WriteLine($"{espanol[i]}, {ingles[i]}, {italiano[i]}");
                            encontrada = true;
                            break;
                        }
                    }

                    if (!encontrada)
                    {
                        Console.WriteLine("La palabra no corresponde a la lección actual.");
                    }
                }
            }
        }

        static void Ejercicio3()
        {
            Console.WriteLine("\tCALIFICACIÓN DE UN CURSO");

            int[] notas = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = rnd.Next(50, 101);
            }

            int opcion = 0;

            while (opcion != 3)
            {
                Console.WriteLine("\n1. Reporte de rendimiento");
                Console.WriteLine("2. Estadísticas");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    foreach (int nota in notas)
                    {
                        if (nota >= 50 && nota <= 64)
                            Console.ForegroundColor = ConsoleColor.Red;

                        else if (nota >= 65 && nota <= 79)
                            Console.ForegroundColor = ConsoleColor.Yellow;

                        else
                            Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write(nota + " ");
                    }

                    Console.ResetColor();
                    Console.WriteLine();
                }

                else if (opcion == 2)
                {
                    int suma = 0;
                    int mayor = notas[0];
                    int menor = notas[0];

                    foreach (int n in notas)
                    {
                        suma += n;

                        if (n > mayor) mayor = n;
                        if (n < menor) menor = n;
                    }

                    double promedio = (double)suma / notas.Length;

                    Console.WriteLine("Promedio: " + promedio);
                    Console.WriteLine("Nota mayor: " + mayor);
                    Console.WriteLine("Nota menor: " + menor);
                }
            }
        }
        static void Ejercicio4()
        {
            Console.WriteLine("\tSIMULACIÓN DE PAGOS DE PLANILLA");

            string[] nombres = { "Ana", "Mario", "Saúl", "Karla", "María", "José" };
            double[] salarioHora = { 100, 125.50, 98.65, 125, 132.50, 102.50 };
            double[] horas = new double[6];

            for (int i = 0; i < horas.Length; i++)
            {
                Console.Write($"Ingrese horas trabajadas por {nombres[i]}: ");
                horas[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPagos semanales:");

            for (int i = 0; i < nombres.Length; i++)
            {
                double pago;

                if (horas[i] > 40)
                {
                    double extras = horas[i] - 40;
                    pago = (40 * salarioHora[i]) + (extras * salarioHora[i] * 1.5);
                }
                else
                {
                    pago = horas[i] * salarioHora[i];
                }

                Console.WriteLine($"{nombres[i]} -> Q {pago}");
            }
        }
    }
}
