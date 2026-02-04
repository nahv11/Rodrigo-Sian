using System;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombreal, nombrecur;

            Console.WriteLine("Ingresa el nombre del curso: ");
            nombrecur = Console.ReadLine();
            Console.WriteLine("Ingresa el nombre del estudiante: ");
            nombreal = Console.ReadLine();
            Console.WriteLine("El nombre del estudiante es: "+nombreal+ "\nEl nombre del curso es: " + nombrecur);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}

