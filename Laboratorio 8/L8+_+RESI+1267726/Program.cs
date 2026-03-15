using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8___RESI_1267726
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___1 - 20 Numeros___");
            int numero;
            int mayor = int.MinValue;
            int menor = int.MaxValue;
            int suma = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Ingrese el número " + i + ": ");
                numero = int.Parse(Console.ReadLine());

                if (numero > mayor)
                    mayor = numero;

                if (numero < menor)
                    menor = numero;

                suma += numero;
            }

            double promedio = (double)suma / 20;

            Console.WriteLine("\nNúmero mayor: " + mayor);
            Console.WriteLine("Número menor: " + menor);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("___2 - 20 Numeros___");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 7 == 0)
                    Console.WriteLine("ParSiete");
                else if (i % 2 == 0)
                    Console.WriteLine("Par");
                else if (i % 7 == 0)
                    Console.WriteLine("Siete");
                else
                    Console.WriteLine(i);
            }
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("___3 - 10 Clientes___");
            double compra, totalPagar;
            double totalVentas = 0;
            int clientesConDescuento = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese el monto de compra del cliente " + i + ": ");
                compra = double.Parse(Console.ReadLine());

                if (compra > 700)
                {
                    totalPagar = compra - (compra * 0.12);
                    clientesConDescuento++;
                }
                else if (compra > 300)
                {
                    totalPagar = compra - (compra * 0.05);
                    clientesConDescuento++;
                }
                else
                {
                    totalPagar = compra;
                }

                Console.WriteLine("Total a pagar: Q" + totalPagar);
                totalVentas += totalPagar;
            }

            Console.WriteLine("\nClientes con descuento: " + clientesConDescuento);
            Console.WriteLine("Total de ventas del día: Q" + totalVentas);
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("___4 - Numero entero___");
            int numero, opcion;

            Console.Write("Ingrese un número entero: ");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nElija una opción:");
            Console.WriteLine("1. Mostrar números desde el número hasta 1");
            Console.WriteLine("2. Mostrar múltiplos de 3 hasta el número");
            Console.WriteLine("3. Mostrar múltiplos de 5 hasta el número");

            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                for (int i = numero; i >= 1; i--)
                    Console.WriteLine(i);
            }
            else if (opcion == 2)
            {
                for (int i = 1; i <= numero; i++)
                    if (i % 3 == 0)
                        Console.WriteLine(i);
            }
            else if (opcion == 3)
            {
                for (int i = 1; i <= numero; i++)
                    if (i % 5 == 0)
                        Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("___5 - Triangulo___");
            int filas;

            Console.Write("Ingrese el número de filas: ");
            filas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= filas; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
