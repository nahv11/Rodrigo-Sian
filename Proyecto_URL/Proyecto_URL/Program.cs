using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_URL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            string operador;
            string codigoTurno;
            int capacidad;

            int ticketsCreados = 0;
            int ticketsCerrados = 0;
            double dinero = 0;
            int tiempo = 0;
            bool ticketActivo = false;

            string placa = "";
            int tipoVehiculo = 0;
            string cliente = "";
            int minutoEntrada = 0;
            bool vip = false;
            int opcion = 0;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("___SISTEMA SMARTPARK___");

            Console.Write("Nombre del operador: ");
            operador = Console.ReadLine();

            //Codigo a ingresar por el usuario
            do
            {
                Console.Write("Codigo de turno (4 caracteres): ");
                codigoTurno = Console.ReadLine();

                if (codigoTurno.Length != 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: El codigo debe tener 4 caracteres");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (codigoTurno.Length != 4);

            //Capacidad del parqueo segun el usuario 
            do
            {
                Console.Write("Capacidad del parqueo (minimo 10): ");
                capacidad = int.Parse(Console.ReadLine());

                if (capacidad < 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La capacidad minima es 10");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (capacidad < 10);


            while (opcion != 5)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("\n_____MENU SMARTPARK___");
                Console.WriteLine("1. Crear ticket de entrada");
                Console.WriteLine("2. Registrar salida");
                Console.WriteLine("3. Ver estado del parqueo");
                Console.WriteLine("4. Simular paso del tiempo");
                Console.WriteLine("5. Salir");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Seleccione opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {

                    //Aqui creamos los tickets
                    case 1:

                        if (ticketActivo)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ya existe un ticket activo.");
                            break;
                        }

                        if ((ticketsCreados - ticketsCerrados) >= capacidad)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("El parqueo esta lleno.");
                            break;
                        }

                        do
                        {
                            Console.Write("Placa (6-8 caracteres): ");
                            placa = Console.ReadLine();

                            if (placa.Length < 6 || placa.Length > 8 || placa.Contains(" "))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Placa invalida.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                        } while (placa.Length < 6 || placa.Length > 8 || placa.Contains(" "));

                        Console.WriteLine("Tipo de vehiculo:");
                        Console.WriteLine("1 Moto");
                        Console.WriteLine("2 Auto");
                        Console.WriteLine("3 Pickup/SUV");

                        do
                        {
                            tipoVehiculo = int.Parse(Console.ReadLine());

                        } while (tipoVehiculo < 1 || tipoVehiculo > 3);

                        Console.Write("Nombre del cliente: ");
                        cliente = Console.ReadLine();

                        Console.Write("Cliente VIP? (1=Si / 0=No): ");
                        int v = int.Parse(Console.ReadLine());

                        vip = (v == 1);

                        minutoEntrada = tiempo;

                        ticketActivo = true;

                        ticketsCreados++;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ticket creado correctamente.");

                        break;

                    //Salida de un vehiculo agregando un tiempo simulado
                    case 2:

                        if (!ticketActivo)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No existe ticket activo.");
                            break;
                        }

                        int minutos = tiempo - minutoEntrada;

                        double tarifa = 0;

                        if (tipoVehiculo == 1)
                            tarifa = 5;

                        if (tipoVehiculo == 2)
                            tarifa = 10;

                        if (tipoVehiculo == 3)
                            tarifa = 15;

                        double horas = Math.Ceiling(minutos / 60.0);

                        double cobro = horas * tarifa;

                        if (minutos <= 15)
                            cobro = 0;

                        if (horas > 6)
                            cobro += 25;

                        if (vip)
                            cobro = cobro * 0.90;

                        if (horas > 12)
                        {
                            cobro = cobro * 1.20;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Se aplico recargo por permanencia extrema.");
                        }

                        dinero += cobro;

                        ticketsCerrados++;

                        ticketActivo = false;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Monto a pagar: Q" + cobro);
                        Console.WriteLine("Total recaudado: Q" + dinero);

                        break;

                    //Estado del parqueo 
                    case 3:

                        Console.ForegroundColor = ConsoleColor.White;

                        int ocupados = ticketActivo ? 1 : 0;

                        Console.WriteLine("\nEstado del parqueo");
                        Console.WriteLine("Capacidad total: " + capacidad);
                        Console.WriteLine("Espacios ocupados: " + ocupados);
                        Console.WriteLine("Espacios disponibles: " + (capacidad - ocupados));
                        Console.WriteLine("Tiempo simulado: " + tiempo + " minutos");
                        Console.WriteLine("Total recaudado: Q" + dinero);
                        Console.WriteLine("Tickets creados: " + ticketsCreados);
                        Console.WriteLine("Tickets cerrados: " + ticketsCerrados);

                        break;

                    //Tiempo simulado
                    case 4:

                        int minutosSim;

                        do
                        {
                            Console.Write("Minutos a simular (1-1440) (minutos): ");
                            minutosSim = int.Parse(Console.ReadLine());

                        } while (minutosSim < 1 || minutosSim > 1440);

                        tiempo += minutosSim;

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Tiempo actual: " + tiempo + " minutos");

                        if (ticketActivo)
                        {
                            int estacionado = tiempo - minutoEntrada;

                            if (estacionado > 360)
                                Console.WriteLine("Advertencia: multa proxima.");

                            if (estacionado > 720)
                                Console.WriteLine("Advertencia: permanencia extrema.");
                        }

                        break;

                    //Salir del programa
                    case 5:

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("\nResumen del turno");
                        Console.WriteLine("Operador: " + operador);
                        Console.WriteLine("Codigo turno: " + codigoTurno);
                        Console.WriteLine("Tickets creados: " + ticketsCreados);
                        Console.WriteLine("Tickets cerrados: " + ticketsCerrados);
                        Console.WriteLine("Dinero recaudado: Q" + dinero);

                        break;

                    default:

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opcion invalida");

                        break;
                }

                Console.ResetColor();
            }
        }
    }
}
