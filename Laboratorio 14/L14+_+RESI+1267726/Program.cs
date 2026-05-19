using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14___RESI_1267726
{
    // EJERCICIO 1 - CUENTA BANCARIA
    class CuentaBancaria
    {
        public string titular;
        public string numeroCuenta;
        public decimal saldo;

        // Constructor
        public CuentaBancaria(string titular, string numeroCuenta, decimal saldo)
        {
            this.titular = titular;
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
        }

        // Mostrar información
        public void MostrarInformacion()
        {
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("Número de Cuenta: " + numeroCuenta);
            Console.WriteLine("Saldo: Q" + saldo);
            Console.WriteLine();
        }

        // Depositar dinero
        public void Depositar(decimal monto)
        {
            saldo += monto;
            Console.WriteLine("Se depositaron Q" + monto);
        }

        // Retirar dinero
        public void Retirar(decimal monto)
        {
            if (saldo >= monto)
            {
                saldo -= monto;
                Console.WriteLine("Se retiraron Q" + monto);
            }
            else
            {
                Console.WriteLine("Fondos insuficientes.");
            }
        }
    }
    // EJERCICIO 2 - PRODUCTO

    class Producto
    {
        public string nombre;
        public decimal precio;
        public int cantidad;

        // Constructor
        public Producto(string nombre, decimal precio, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        // Mostrar información
        public void MostrarInformacion()
        {
            Console.WriteLine("Producto: " + nombre);
            Console.WriteLine("Precio: Q" + precio);
            Console.WriteLine("Cantidad: " + cantidad);
            Console.WriteLine();
        }

        // Vender producto
        public void Vender(int cantidadVendida)
        {
            if (cantidad >= cantidadVendida)
            {
                cantidad -= cantidadVendida;
                Console.WriteLine("Se vendieron " + cantidadVendida + " unidades.");
            }
            else
            {
                Console.WriteLine("No hay suficiente stock.");
            }
        }

        // Reabastecer producto
        public void Reabastecer(int cantidadNueva)
        {
            cantidad += cantidadNueva;
            Console.WriteLine("Se agregaron " + cantidadNueva + " unidades.");
        }
    }
    // EJERCICIO 3 - ESTUDIANTE

    class Estudiante
    {
        public string nombre;
        public int edad;
        public string grado;
        public decimal[] notas;

        // Constructor
        public Estudiante(string nombre, int edad, string grado, decimal[] notas)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.grado = grado;
            this.notas = notas;
        }

        // Calcular promedio
        public decimal CalcularPromedio()
        {
            decimal suma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                suma += notas[i];
            }

            return suma / notas.Length;
        }

        // Mostrar información
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Grado: " + grado);

            Console.Write("Notas: ");

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write(notas[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Promedio: " + CalcularPromedio());
            Console.WriteLine();
        }

        // Verificar aprobación
        public void Aprobar()
        {
            if (CalcularPromedio() >= 61)
            {
                Console.WriteLine(nombre + " aprobó.");
            }
            else
            {
                Console.WriteLine(nombre + " reprobó.");
            }
        }

        // Agregar nota
        public void AgregarNota(decimal nuevaNota)
        {
            decimal[] nuevasNotas = new decimal[notas.Length + 1];

            for (int i = 0; i < notas.Length; i++)
            {
                nuevasNotas[i] = notas[i];
            }

            nuevasNotas[nuevasNotas.Length - 1] = nuevaNota;

            notas = nuevasNotas;
        }
    }

    // PROGRAMA PRINCIPAL

    internal class Program
    {
        static void Main(string[] args)
        {
            // EJERCICIO 1 - CUENTAS BANCARIAS

            Console.WriteLine("\n");
            Console.WriteLine("EJERCICIO 1 - CUENTAS BANCARIAS");
            Console.WriteLine("\n");

            CuentaBancaria cuenta1 = new CuentaBancaria("Rodrigo", "001", 1500);
            CuentaBancaria cuenta2 = new CuentaBancaria("Carlos", "002", 2500);

            cuenta1.MostrarInformacion();
            cuenta2.MostrarInformacion();

            Console.WriteLine("Saldo antes del depósito: Q" + cuenta1.saldo);
            cuenta1.Depositar(500);
            Console.WriteLine("Saldo después del depósito: Q" + cuenta1.saldo);

            Console.WriteLine();

            Console.WriteLine("Saldo antes del retiro: Q" + cuenta2.saldo);
            cuenta2.Retirar(1000);
            Console.WriteLine("Saldo después del retiro: Q" + cuenta2.saldo);

            // EJERCICIO 2 - PRODUCTOS

            Console.WriteLine("\n");
            Console.WriteLine("EJERCICIO 2 - PRODUCTOS");
            Console.WriteLine("\n");

            Producto producto1 = new Producto("Laptop", 4500, 10);
            Producto producto2 = new Producto("Mouse", 120, 25);

            producto1.MostrarInformacion();
            producto2.MostrarInformacion();

            Console.WriteLine("Cantidad antes de vender: " + producto1.cantidad);
            producto1.Vender(3);
            Console.WriteLine("Cantidad después de vender: " + producto1.cantidad);

            Console.WriteLine();

            Console.WriteLine("Cantidad antes de reabastecer: " + producto2.cantidad);
            producto2.Reabastecer(10);
            Console.WriteLine("Cantidad después de reabastecer: " + producto2.cantidad);

            // EJERCICIO 3 - ESTUDIANTES

            Console.WriteLine("\n");
            Console.WriteLine("EJERCICIO 3 - ESTUDIANTES");
            Console.WriteLine("\n");

            decimal[] notas1 = { 70, 80, 65 };
            decimal[] notas2 = { 50, 55, 60 };

            Estudiante estudiante1 = new Estudiante("Rodrigo", 19, "Ingeniería", notas1);
            Estudiante estudiante2 = new Estudiante("Ana", 18, "Bachillerato", notas2);

            estudiante1.MostrarInformacion();
            estudiante2.MostrarInformacion();

            estudiante1.Aprobar();
            estudiante2.Aprobar();

            Console.WriteLine();

            Console.WriteLine("Agregando nueva nota a Rodrigo...");
            estudiante1.AgregarNota(90);

            Console.WriteLine();

            Console.WriteLine("Información actualizada:");
            estudiante1.MostrarInformacion();

            Console.ReadKey();
        }
    }
}
