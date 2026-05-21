using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10___RESI_1267726
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA 1: SUMA DE DÍGITOS");
            Console.Write("Ingrese un número: ");
            int num = int.Parse(Console.ReadLine());

            int resultado = SumarDigitos(num);
            Console.WriteLine("Suma de dígitos: " + resultado);

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("PROGRAMA 2: AJUSTE DE SALDO");
            Console.Write("Ingrese saldo: ");
            int saldo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese monto de retiro: ");
            int retiro = int.Parse(Console.ReadLine());

            string mensaje = AjustarSaldo(ref saldo, retiro);
            Console.WriteLine(mensaje);

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("PROGRAMA 3: CONVERSIÓN DE TEMPERATURA");
            Console.Write("Ingrese temperatura en Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = 0;
            string conversion = ConvertirTemperatura(celsius, ref fahrenheit);

            Console.WriteLine(conversion);

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("PROGRAMA 4: SISTEMA DE PUNTOS");
            Console.Write("Ingrese puntos iniciales: ");
            int puntos = int.Parse(Console.ReadLine());

            puntos = AgregarPuntos(ref puntos);
            Console.WriteLine("Después de agregar: " + puntos);

            puntos = QuitarPuntos(ref puntos);
            Console.WriteLine("Después de quitar: " + puntos);

            string nivel = ObtenerNivel(puntos);
            Console.WriteLine("Nivel: " + nivel);

            string estado = EvaluarEstado(puntos);
            Console.WriteLine("Estado: " + estado);

            Console.WriteLine("\nFin del programa.");
        }

        // 1. FUNCIÓN SUMA DE DÍGITOS
        static int SumarDigitos(int numero)
        {
            int suma = 0;

            while (numero > 0)
            {
                suma += numero % 10;
                numero /= 10;
            }

            return suma;
        }
        // 2. AJUSTE DE SALDO (REFERENCIA)
        static string AjustarSaldo(ref int saldo, int retiro)
        {
            if (saldo >= retiro)
            {
                saldo -= retiro;
                return "Saldo = " + saldo;
            }
            else
            {
                return "Saldo = " + saldo + " (sin cambios)";
            }
        }

        // 3. CONVERSIÓN DE TEMPERATURA
        static string ConvertirTemperatura(double c, ref double f)
        {
            f = (c * 9 / 5) + 32;
            return "F = " + f;
        }

        // 4.1 AGREGAR PUNTOS
        static int AgregarPuntos(ref int puntos)
        {
            puntos += 10;
            if (puntos > 100)
                puntos = 100;

            return puntos;
        }

        // QUITAR PUNTOS
        static int QuitarPuntos(ref int puntos)
        {
            puntos -= 7;
            if (puntos < 0)
                puntos = 0;

            return puntos;
        }

        // OBTENER NIVEL
        static string ObtenerNivel(int puntos)
        {
            if (puntos >= 80)
                return "Avanzado";
            else if (puntos >= 50)
                return "Intermedio";
            else
                return "Básico";
        }

        // EVALUAR ESTADO
        static string EvaluarEstado(int puntos)
        {
            if (puntos == 100)
                return "Excelente";
            else if (puntos >= 70)
                return "Aprobado";
            else
                return "Reprobado";
        }
    }
}
