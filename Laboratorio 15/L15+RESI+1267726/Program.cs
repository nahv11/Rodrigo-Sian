using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15_RESI_1267726
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("LABORATORIO 15 / Rodrigo Sian");
                Console.WriteLine("1. Retirar efectivo");
                Console.WriteLine("2. Calcular descuento");
                Console.WriteLine("3. Depositar dinero");
                Console.WriteLine("4. Simular crédito personal");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Retiro();
                        break;

                    case 2:
                        Descuento();
                        break;

                    case 3:
                        Deposito();
                        break;

                    case 4:
                        Credito();
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 5);
        }

        // RETIRAR EFECTIVO
        static void Retiro()
        {
            Console.Clear();

            Console.WriteLine("RETIRAR EFECTIVO: ");

            Console.Write("Ingrese saldo disponible: ");
            double saldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese monto a retirar: ");
            double retiro = Convert.ToDouble(Console.ReadLine());

            if (retiro <= 0)
            {
                Console.WriteLine("Error: monto inválido.");
            }
            else if (retiro > saldo)
            {
                Console.WriteLine("Error: fondos insuficientes.");
            }
            else
            {
                saldo = saldo - retiro;

                Console.WriteLine("Retiro realizado correctamente.");
                Console.WriteLine("Nuevo saldo: Q" + saldo);
            }
        }

        // CALCULAR DESCUENTO
        static void Descuento()
        {
            Console.Clear();

            Console.WriteLine("CALCULAR DESCUENTO:");

            Console.Write("Ingrese precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese porcentaje de descuento: ");
            double descuento = Convert.ToDouble(Console.ReadLine());

            if (descuento < 0 || descuento > 100)
            {
                Console.WriteLine("Error: descuento inválido.");
            }
            else
            {
                double resultado;

                resultado = precio - (precio * descuento / 100);

                Console.WriteLine("Precio original: Q" + precio);
                Console.WriteLine("Descuento aplicado: " + descuento + "%");
                Console.WriteLine("Precio final: Q" + resultado);
            }
        }

        // DEPOSITAR DINERO
        static void Deposito()
        {
            Console.Clear();

            Console.WriteLine("DEPOSITAR DINERO: ");

            Console.Write("Ingrese saldo actual: ");
            double saldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese monto a depositar: ");
            double deposito = Convert.ToDouble(Console.ReadLine());

            if (deposito <= 0)
            {
                Console.WriteLine("Error: monto inválido.");
            }
            else
            {
                saldo = saldo + deposito;

                Console.WriteLine("Depósito realizado correctamente.");
                Console.WriteLine("Nuevo saldo: Q" + saldo);
            }
        }

        // SIMULADOR DE CRÉDITO
        static void Credito()
        {
            Console.Clear();

            Console.WriteLine("SIMULADOR DE CRÉDITO PERSONAL\n");

            double capital = 10000;
            double tasa = 0.05;
            double intereses;
            double abonos = 1500;

            for (int mes = 1; mes <= 8; mes++)
            {
                intereses = capital * tasa;

                capital = capital + intereses - abonos;

                Console.WriteLine("Mes: " + mes);
                Console.WriteLine("Intereses: Q" + intereses);
                Console.WriteLine("Abono: Q" + abonos);
                Console.WriteLine("Capital restante: Q" + capital);
                Console.WriteLine("\n");
            }
        }
    }
}