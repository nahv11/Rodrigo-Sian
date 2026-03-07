using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6___RESI_1267726
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______Menu grados______");
            Console.WriteLine("Ingresa la opcion dentro del menu del tipo de conversion que necesites: ");
            Console.WriteLine("1. Celsius a Fahrenheit\n" +
                "2. De Fahrenheit a Celsius\n" + "3. De Celsius a Kelvin");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("___Celsius a Fahrenheit___\n");
                    Console.WriteLine("Ingresa los grados celsius (°C): ");
                    double cel = double.Parse(Console.ReadLine());
                    double far = (1.8 * cel) + 32;
                    Console.WriteLine("Conversion en grados Fahrenheit: " + far + " °F");
                    break;
                case 2:
                    Console.WriteLine("___Fahrenheit a Celsius___\n");
                    Console.WriteLine("Ingresa los grados fahrenheit (°F): ");
                    double far1 = double.Parse(Console.ReadLine());
                    double cel1 = (far1 - 32) / 1.8;
                    Console.WriteLine("Conversion en grados Celsius: " + cel1 + " °C");
                    break;
                case 3:
                    Console.WriteLine("___Celsius a Kelvin___\n");
                    Console.WriteLine("Ingresa los grados celsius (°C): ");
                    double cel2 = double.Parse(Console.ReadLine());
                    double kel = cel2 + 273.15;
                    Console.WriteLine("Conversion en grados kelvin: " + kel);
                    break;
                default:
                    Console.WriteLine("Opcion Incorrecta...");
                    break;
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("______Tienda______\n");
            Console.WriteLine("1. Cliente regular");
            Console.WriteLine("2. Cliente VIP");
            Console.WriteLine("\nDESCUENTOS: regular: 5%, VIP 10%");
            Console.WriteLine("Ingresa el tipo de cliente que eres: ");
            int op2 = int.Parse(Console.ReadLine());
            switch (op2)
            {
                case 1:
                    Console.WriteLine("______Cliente regular______\n");
                    Console.WriteLine("Ingresa cuantas unidades compraste: ");
                    int uni = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa cuanto gastaste en tu compra: ");
                    double gasto = double.Parse(Console.ReadLine());
                    if (uni > 0 && uni < 100)
                    {
                        double desc = gasto * 0.05;
                        double tot = gasto - desc;
                        Console.WriteLine("Tu descuento es de: Q." + desc);
                        Console.WriteLine("\nTotal a pagar (Con descuento): Q." + tot);
                    }
                    else if (uni >= 100)
                    {
                        double desc = gasto * 0.15;
                        double tot = gasto - desc;
                        Console.WriteLine("_____Cliente regular/mayorista_____\n");
                        Console.WriteLine("Tu descuento es de: Q." + desc);
                        Console.WriteLine("\nTotal a pagar (Con descuento): Q." + tot);
                    }
                    else
                    {
                        Console.WriteLine("Opcion invalida...");
                    }
                    break;
                case 2:
                    Console.WriteLine("______Cliente VIP______\n");
                    Console.WriteLine("Ingresa cuantas unidades compraste: ");
                    int uni2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa cuanto gastaste en tu compra: ");
                    double gasto2 = double.Parse(Console.ReadLine());
                    if (uni2 > 0 && uni2 < 100)
                    {
                        double desc = gasto2 * 0.10;
                        double tot = gasto2 - desc;
                        Console.WriteLine("Tu descuento es de: Q." + desc);
                        Console.WriteLine("\nTotal a pagar (Con descuento): Q." + tot);
                    }
                    else if (uni2 >= 100)
                    {
                        double desc = gasto2 * 0.15;
                        double tot = gasto2 - desc;
                        Console.WriteLine("_____Cliente regular/mayorista_____\n");
                        Console.WriteLine("Tu descuento es de: Q." + desc);
                        Console.WriteLine("\nTotal a pagar (Con descuento): Q." + tot);
                    }
                    else
                    {
                        Console.WriteLine("Opcion invalida...");
                    }
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta...");
                    break;
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("______Estacionamiento______\n");
            Console.WriteLine("Bienvenido al sistema de pago del estacionamiento\n");
            Console.WriteLine("TARIFAS: \nMenos de 2 horas → $5 por hora\nEntre 2 y 5 horas → $4 por hora\nMás de 5 horas → $3 por hora");
            Console.WriteLine("\nIngresa tu tiempo de estacionamiento en horas: ");
            int horas = int.Parse(Console.ReadLine());
            if (horas < 2 && horas > 0)
            {
                double pago = horas * 5;
                Console.WriteLine("Total a pagar: $." + pago);
            }
            else if (horas >= 2 && horas <= 5)
            {
                double pago = horas * 4;
                Console.WriteLine("Total a pagar: $." + pago);
            }
            else if (horas > 5)
            {
                double pago = horas * 3;
                Console.WriteLine("Total a pagar: $." + pago);
            }
            else
            {
                Console.WriteLine("Opcion invalida...");
            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("______Evaluacion empresarial______\n");
            Console.Write("Introduce tu puntuación (0.0, 0.4, 0.6 o más): \n");
            double puntuacion = Convert.ToDouble(Console.ReadLine());
            string nivel;

            if (puntuacion == 0.0)
            {
                nivel = "Inaceptable";
            }
            else if (puntuacion == 0.4)
            {
                nivel = "Aceptable";
            }
            else if (puntuacion >= 0.6)
            {
                nivel = "Meritorio";
            }
            else
            {
                Console.WriteLine("Puntuación no válida.");
                return;
            }
            double dinero = 2400 * puntuacion;
            Console.WriteLine("Nivel: " + nivel);
            Console.WriteLine("Cantidad a recibir: " + dinero);
        }
    }
}
