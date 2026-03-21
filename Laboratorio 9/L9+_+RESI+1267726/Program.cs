using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9___RESI_1267726
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilice en $ para evitar agregar + para concatenar cada valor en los console.writeline
            // ---------- Problema 1 - Parametros por Valor ----------
            Console.WriteLine("---------- Problema 1 - Parametros por Valor ----------");
            Console.WriteLine("Ingresa una palabra: ");
            string palabra = Console.ReadLine();
            longitud(palabra);

            PausarYLimpiar();

            // ---------- Problema 2 - Parametros por Referencia ----------
            Console.WriteLine("---------- Problema 2 - Parametros por Referencia ----------");
            Console.WriteLine("Ingresa tu primer numero: ");
            Console.Write("A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa tu primer numero: ");
            Console.Write("B = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAntes del intercambio:");
            Console.WriteLine($"A = {a}\nB = {b}");

            intercambiar(ref a, ref b);

            Console.WriteLine("Después del intercambio:");
            Console.WriteLine($"A = {a}\nB = {b}");

            PausarYLimpiar();

            // ---------- Problema 3 - Integración (Cine) ----------
            Console.WriteLine("---------- Problema 3 - Integración (Cine) ----------");
            Console.Write("Ingrese el precio actual del boleto: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el descuento (ej: 0.15 para 15%): ");
            double desc = Convert.ToDouble(Console.ReadLine());

            aplicarPromocion(desc, ref precio);

            PausarYLimpiar();

            // ---------- Problema 4 - Videojuego ----------
            Console.WriteLine("---------- Problema 4 - Simulación de Videojuego ----------");
            int puntosSalud = 10;

            mostrarSalud(puntosSalud);

            Console.WriteLine("\nRecibiendo daño...");
            recibirDaño(ref puntosSalud);
            mostrarSalud(puntosSalud);

            Console.WriteLine("\nCurando personaje...");
            curar(ref puntosSalud);
            mostrarSalud(puntosSalud);

            calificarDesempeño(puntosSalud);

            Console.WriteLine("\nFin de la simulación. Presione una tecla para salir.");
            Console.ReadKey();
        }

        // Metodos
        static void PausarYLimpiar()
        {
            Console.WriteLine("\nPresiona una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        // 1
        static void longitud(string pal)
        {
            Console.WriteLine("Cantidad de caracteres: " + pal.Length);
        }

        // 2
        static void intercambiar(ref int uno, ref int dos)
        {
            int aux = uno;
            uno = dos;
            dos = aux;
        }

        // 3
        static void aplicarPromocion(double descuento, ref double precioBoleto)
        {
            Console.WriteLine($"Precio antes: {precioBoleto}");
            precioBoleto -= (precioBoleto * descuento);
            Console.WriteLine($"Precio después: {precioBoleto}");
        }

        // 4
        static void recibirDaño(ref int salud)
        {
            salud -= 5;
            if (salud < 0) salud = 0;
        }

        static void curar(ref int salud)
        {
            salud += 3;
            if (salud > 15) salud = 15;
        }

        static void mostrarSalud(int salud)
        {
            if (salud >= 11) Console.ForegroundColor = ConsoleColor.Green;
            else if (salud >= 6) Console.ForegroundColor = ConsoleColor.Yellow;
            else Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"Puntos de salud: {salud}");
            Console.ResetColor();
        }

        static void calificarDesempeño(int salud)
        {
            string rango = "";
            if (salud == 15) rango = "S";
            else if (salud >= 11) rango = "A";
            else if (salud >= 6) rango = "B";
            else if (salud >= 1) rango = "C";

            Console.WriteLine($"Calificación: {rango}");
        }
    }
}
