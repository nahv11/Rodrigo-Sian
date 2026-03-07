using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5_RodrigoSian_1267726
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____Desafío # 1: Estructuras Selectivas____");
            String num;
            Console.WriteLine("Ingresa un numero entero mayor, menor o igual a cero: ");
            num = Console.ReadLine();
            int NUM = int.Parse(num);
            if (NUM > 0)
            {
                Console.WriteLine("\nEl numero: " + NUM + ", es positivo.");
            }
            else if (NUM < 0)
            {
                Console.WriteLine("El numero: " + NUM + "es negativo.");
            }
            else if (NUM == 0)
            {
                Console.WriteLine("Tu numero es 0");
            }
            else
            {
                Console.WriteLine("Numero incorrecto... \n");
            }
            Console.WriteLine(" \n____Desafío # 2: Estructuras Selectivas____");
            String anio;
            Console.WriteLine("Ingresa el anio que deseas saber:");
            anio = Console.ReadLine();
            int anioent = int.Parse(anio);
            if ((anioent % 4 == 0 && anioent % 100 != 0) || (anioent % 400 == 0))
            {
                Console.WriteLine("El anio es bisiesto");
            }
            else
            {
                Console.WriteLine("El anio no es bisiesto");
            }
            Console.WriteLine(" \n____Desafío #3: Estructuras Selectivas____");
            Console.WriteLine("Ingresa tu ingreso mensual:");
            double enting = double.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuentas con multa? (si / no)");
            string respuesta = Console.ReadLine().ToLower();

            bool mul = respuesta == "si";

            double arbitrio = 0;
            double total = 0;

            if (enting >= 500.01 && enting <= 1000)
            {
                arbitrio = 10;
            }
            else if (enting <= 3000)
            {
                arbitrio = 15;
            }
            else if (enting <= 6000)
            {
                arbitrio = 50;
            }
            else if (enting <= 9000)
            {
                arbitrio = 75;
            }
            else if (enting <= 12000)
            {
                arbitrio = 100;
            }
            else
            {
                arbitrio = 150;
            }

            if (mul)
            {
                total = arbitrio * 2;
                Console.WriteLine("Tu arbitrio CON MULTA es de: Q" + total);
            }
            else
            {
                total = arbitrio;
                Console.WriteLine("Tu arbitrio SIN MULTA es de: Q" + total);
            }
            Console.WriteLine(" \n____Desafío #4: Estructuras selectivas & Operadores aritméticos ____");
            Console.WriteLine("COSTO POR HORA: Q.10.00\tPago en billetes");
            Console.WriteLine("Ingresa tu cantidad de horas en el parqueo: ");
            int horas = int.Parse(Console.ReadLine());
            int pago = horas * 10;
            Console.WriteLine("TOTAL A PAGAR: Q" + pago);
            Console.WriteLine("Ingresa el monto del billete: ");
            int billete = int.Parse(Console.ReadLine());
            if (billete > 0 && billete < pago)
            {
                Console.WriteLine("ERROR - CANTIDAD INSUFICIENTE");
            }
            else if (billete == pago)
            {
                Console.WriteLine("No se necesita cambio.\tGRACIAS");
            }
            else
            {
                int vuelto = billete - pago;
                Console.WriteLine("Cantidad mayor al pago, su vuelto es de: " + vuelto);
                int b100 = vuelto / 100;
                vuelto = vuelto % 100;

                int b50 = vuelto / 50;
                vuelto = vuelto % 50;

                int b20 = vuelto / 20;
                vuelto = vuelto % 20;

                int b10 = vuelto / 10;
                vuelto = vuelto % 10;

                int b5 = vuelto / 5;
                vuelto = vuelto % 5;

                int b1 = vuelto / 1;

                Console.WriteLine("\tDesglose de billetes");

                if (b100 > 0) Console.WriteLine("Billetes de Q100: " + b100);
                if (b50 > 0) Console.WriteLine("Billetes de Q50: " + b50);
                if (b20 > 0) Console.WriteLine("Billetes de Q20: " + b20);
                if (b10 > 0) Console.WriteLine("Billetes de Q10: " + b10);
                if (b5 > 0) Console.WriteLine("Billetes de Q5: " + b5);
                if (b1 > 0) Console.WriteLine("Billetes de Q1: " + b1);
            }
        }
    }
}
