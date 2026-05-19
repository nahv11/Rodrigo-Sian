using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class persona //ejercicio 1
{
    public string nombre;
    public int edad;
    public double altura;
    public bool estudiante;
}

class vehiculo //ejercicio 2
{
    public string marca;
    public string modelo;
    public int anio;
    public string color;
    public string placa;
}

class producto //ejercicio 3
{
    public string codigo;
    public string nombre;
    public double precio;
    public int stock;
    public bool disponible;
}

class mascota //ejercicio 4
{
    public string nombre;
    public string especie;
    public int edad;
    public double peso;
    public bool vacunado;
}

namespace L13__RESI_1267726
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            Console.WriteLine("-----------Ejercicio 1 – Clase Persona-----------");
            persona per = new persona();

            Console.WriteLine("Ingresa tu nombre: ");
            per.nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad: ");
            per.edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa tu altura: ");
            per.altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa si eres estudiante (True/False): ");
            per.estudiante = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\n\nTus datos son: \n" +
            "Nombre: " + per.nombre +
            "\nEdad: " + per.edad +
            "\nAltura: " + per.altura +
            "\nEstudiante: " + per.estudiante);

            Console.WriteLine("Presiona para continuar....");
            Console.ReadKey();
            Console.Clear();

            //Ejercicio 2
            Console.WriteLine("-----------Ejercicio 2 – Clase Vehiculo-----------");
            vehiculo ve = new vehiculo();

            Console.WriteLine("Ingresa la marca del vehiculo: ");
            ve.marca = Console.ReadLine();

            Console.WriteLine("Ingresa el modelo del vehiculo: ");
            ve.modelo = Console.ReadLine();

            Console.WriteLine("Ingresa el año del vehiculo: ");
            ve.anio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el color del vehiculo: ");
            ve.color = Console.ReadLine();

            Console.WriteLine("Ingresa la placa del vehiculo: ");
            ve.placa = Console.ReadLine();

            Console.WriteLine("\n\nDatos del vehiculo: \n" +
            "Marca: " + ve.marca +
            "\nModelo: " + ve.modelo +
            "\nAño: " + ve.anio +
            "\nColor: " + ve.color +
            "\nPlaca: " + ve.placa);

            Console.WriteLine("Presiona para continuar....");
            Console.ReadKey();
            Console.Clear();

            //Ejercicio 3
            Console.WriteLine("-----------Ejercicio 3 – Clase Producto-----------");

            producto p1 = new producto();
            producto p2 = new producto();

            Console.WriteLine("---- Producto 1 ----");
            Console.WriteLine("Codigo: ");
            p1.codigo = Console.ReadLine();

            Console.WriteLine("Nombre: ");
            p1.nombre = Console.ReadLine();

            Console.WriteLine("Precio: ");
            p1.precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Stock: ");
            p1.stock = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Disponible (True/False): ");
            p1.disponible = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\n---- Producto 2 ----");
            Console.WriteLine("Codigo: ");
            p2.codigo = Console.ReadLine();

            Console.WriteLine("Nombre: ");
            p2.nombre = Console.ReadLine();

            Console.WriteLine("Precio: ");
            p2.precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Stock: ");
            p2.stock = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Disponible (True/False): ");
            p2.disponible = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\n\nDatos de los productos:");

            Console.WriteLine("\nProducto 1:\n" +
            "Codigo: " + p1.codigo +
            "\nNombre: " + p1.nombre +
            "\nPrecio: " + p1.precio +
            "\nStock: " + p1.stock +
            "\nDisponible: " + p1.disponible);

            Console.WriteLine("\nProducto 2:\n" +
            "Codigo: " + p2.codigo +
            "\nNombre: " + p2.nombre +
            "\nPrecio: " + p2.precio +
            "\nStock: " + p2.stock +
            "\nDisponible: " + p2.disponible);

            Console.WriteLine("Presiona para continuar....");
            Console.ReadKey();
            Console.Clear();

            //Ejercicio 4
            Console.WriteLine("-----------Ejercicio 4 – Clase Mascota-----------");
            mascota m = new mascota();

            Console.WriteLine("Nombre de la mascota: ");
            m.nombre = Console.ReadLine();

            Console.WriteLine("Especie: ");
            m.especie = Console.ReadLine();

            Console.WriteLine("Edad: ");
            m.edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Peso: ");
            m.peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Vacunado (True/False): ");
            m.vacunado = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\n\nDatos de la mascota:\n" +
            "Nombre: " + m.nombre +
            "\nEspecie: " + m.especie +
            "\nEdad: " + m.edad +
            "\nPeso: " + m.peso +
            "\nVacunado: " + m.vacunado);

            Console.WriteLine("Fin del programa...");
            Console.ReadKey();
        }
    }
}