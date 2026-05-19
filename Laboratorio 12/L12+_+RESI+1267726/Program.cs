using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA 1: MATRIZ 5x5 - DIAGONALES\n");

        int[,] m1 = new int[5, 5];
        LlenarMatriz(m1, 5, 5);

        int sumaPrincipal = SumaDiagonalPrincipal(m1);
        int sumaSecundaria = SumaDiagonalSecundaria(m1);

        Console.WriteLine("\nSuma diagonal principal: " + sumaPrincipal);
        Console.WriteLine("Suma diagonal secundaria: " + sumaSecundaria);

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("PROGRAMA 2: MATRIZ 4x6 - PARES E IMPARES\n");

        int[,] m2 = new int[4, 6];
        LlenarMatriz(m2, 4, 6);

        int pares = ContarPares(m2);
        int impares = ContarImpares(m2);

        Console.WriteLine("\nCantidad de números pares: " + pares);
        Console.WriteLine("Cantidad de números impares: " + impares);

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("PROGRAMA 3: REGISTRO DE NOTAS\n");

        float[,] notas = new float[5, 4];
        IngresarNotas(notas);

        for (int i = 0; i < 5; i++)
        {
            float prom = Promedio(notas, i);
            bool estado = Aprueba(prom);

            Console.WriteLine("Estudiante " + (i + 1) + ": Promedio = " + prom.ToString("F2") +
                              " -> " + (estado ? "Aprobado" : "Reprobado"));
        }

        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("PROGRAMA 4: MATRIZ 3x3 - SIMETRÍA\n");

        int[,] m4 = new int[3, 3];
        LlenarMatriz(m4, 3, 3);

        bool esSimetrica = EsSimetrica(m4);

        Console.WriteLine("\nLa matriz es: " + (esSimetrica ? "Simétrica" : "No Simétrica"));

        Console.WriteLine("\nFin del programa...");
        Console.ReadKey();
    }

    static void LlenarMatriz(int[,] m, int filas, int columnas)
    {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write("Ingrese valor [" + i + "," + j + "]: ");
                m[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int SumaDiagonalPrincipal(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
        {
            suma += m[i, i];
        }
        return suma;
    }

    static int SumaDiagonalSecundaria(int[,] m)
    {
        int suma = 0;
        for (int i = 0; i < 5; i++)
        {
            suma += m[i, 4 - i];
        }
        return suma;
    }

    static int ContarPares(int[,] m)
    {
        int contador = 0;
        foreach (int num in m)
        {
            if (num % 2 == 0)
                contador++;
        }
        return contador;
    }

    static int ContarImpares(int[,] m)
    {
        int contador = 0;
        foreach (int num in m)
        {
            if (num % 2 != 0)
                contador++;
        }
        return contador;
    }

    static void IngresarNotas(float[,] m)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("\nEstudiante " + (i + 1) + ":");
            for (int j = 0; j < 4; j++)
            {
                Console.Write("Nota " + (j + 1) + ": ");
                m[i, j] = float.Parse(Console.ReadLine());
            }
        }
    }

    static float Promedio(float[,] m, int estudiante)
    {
        float suma = 0;
        for (int j = 0; j < 4; j++)
        {
            suma += m[estudiante, j];
        }
        return suma / 4;
    }

    static bool Aprueba(float promedio)
    {
        return promedio >= 61;
    }
    static bool EsSimetrica(int[,] m)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (m[i, j] != m[j, i])
                    return false;
            }
        }
        return true;
    }
}