using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4___RESI_1267726
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Ejercicio 1: El Perfil de un Personaje\n");
                    int contador = 1;
                    String nombre1 = "Mario";
                    String nombre2 = "Bowser";
                    String nombre3 = "Yoshi";
                    int nivel1 = 1;
                    int nivel2 = 2;
                    int nivel3 = 3;
                    float HP1 = 10.12f;
                    float HP2 = 20.05f;
                    float HP3 = 5.11f;
                    Boolean PJ1 = false;
                    Boolean PJ2 = true;
                    Boolean PJ3 = false;
                    Console.WriteLine("Tus personajes son: " + nombre1 +", "+ nombre2 + ", " + nombre3 + "\n" +
                        "Sus niveles respectivamente son: " + nivel1 + ", " + nivel2 + ", " + nivel3 + "\n" +
                        "Sus niveles de vida respectivamente son: " + HP1 + ", " + HP2 + ", " + HP3 + "\n" +
                        "¿Personaje numero 1 es un jefe?: " + PJ1 + "\n" +
                        "¿Personaje numero 2 es un jefe?: " + PJ2 + "\n" +
                        "¿Personaje numero 1 es un jefe?: " + PJ3);

            Console.Write("\nEjercicio 2: Conversión Implícita (De pequeño a grande)\n");
            int numeroEntero = 1500;
            long numeroLargo = numeroEntero;
            double numeroDecimal = numeroLargo;
            Console.WriteLine(numeroDecimal);

                    Console.Write("\nEjercicio 3: Casting Explícito (Pérdida de precisión)\n");
            double precioExacto = 45.89;
            int precioRedondeado = (int)precioExacto;
            Console.Write(precioRedondeado+"\n");

            Console.Write("\nEjercicio 4: De Texto a Número (Parse)\n");
            String numero;
            Console.WriteLine("Ingresan cualquier valor: \n");
            numero=Console.ReadLine();
            int num = int.Parse(numero)+5;
            Console.WriteLine("Tu numero sumado mas 5 es: "+num+"\n");

            Console.Write("Ejercicio 5: El uso de la clase Convert\n");
            string valorBooleano = "true";
            Convert.ToBoolean(valorBooleano);
            string valorDecimal = "25.5";
            Convert.ToDouble(valorDecimal);
            Console.WriteLine("Valor 1: " + valorBooleano + "Valor 2: " + valorDecimal);

            Console.Write("\nEjercicio 6: El proceso inverso (Número a Texto)\n");
            double pi = 3.14159265;
            string piTexto = pi.ToString();
            Console.WriteLine("Número completo: " + piTexto);
            string PI2 = pi.ToString("F2");
            Console.WriteLine("Con dos decimales: " + PI2);

            Console.Write("\nEjercicio 7: Reto Final - Calculadora de IVA\n");
            String precioprod;
            Console.WriteLine("Ingresa el valor del producto: ");
            precioprod = Console.ReadLine();
            Double PRECIO2 = Convert.ToDouble(precioprod);
            Double IVA = PRECIO2*0.21;
            Double preciotot = PRECIO2+IVA;
            Console.WriteLine("El valor del iva es: "+IVA);
            Console.WriteLine("El precio total de: "+preciotot);

            Console.WriteLine("Presiona cualqueri boton para salir...");
            Console.ReadKey();
        }
    }
}
