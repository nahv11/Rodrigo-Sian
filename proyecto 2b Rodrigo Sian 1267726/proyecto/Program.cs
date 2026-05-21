using System;

namespace ProyectoGranja
{
    //catálogo de cultivos disponibles
    class Cultivo
    {
        public string Nombre;
        public int TiempoCrecimiento;
        public double CostoSemilla;
        public double IngresoCosecha;
        public int InventarioDisponible;
    }

    //celda/sección de la cuadrícula de tierra
    class Parcela
    {
        public string TipoCultivo = "Vacía";
        public int MesesFaltantes = 0;
        public double IngresoEsperado = 0.0;
        public bool EstaOcupada = false;
    }

    class GranjaSimulator
    {
        //variables globales
        private double capitalDisponible;
        private double capitalInicial;
        private int totalEmpleados;
        private double sueldoMensual;
        private int mesesRestantes;
        private int totalMesesSimulados = 0;
        private int filasTerreno;
        private int columnasTerreno;

        //historial contable solicitado para el reporte final
        private double ingresosPorCosechas = 0;
        private double gastosMateriaPrima = 0;
        private double gastosManoObra = 0;

        private Cultivo[] catalogoSemillas;
        private Parcela[,] matrizGranja;

        public void Iniciar()
        {
            MostrarIntroduccion();
            ConfigurarSimulacion();
            InicializarComponentes();
            BuclePrincipal();
            MostrarReporteFinal();
        }

        private void MostrarIntroduccion()
        {
            Console.WriteLine("\n\tSISTEMA DE GESTIÓN DE GRANJA\n");
            Console.WriteLine("Bienvenido al software de administración agrícola.");
            Console.WriteLine("Configure los parámetros iniciales para comenzar.");
            Console.WriteLine("...................................................\n");
        }

        private void ConfigurarSimulacion()
        {
            capitalDisponible = LeerDouble("Ingrese el fondo de capital inicial (Q): ", 0);
            capitalInicial = capitalDisponible;

            totalEmpleados = LeerEntero("Ingrese el número de trabajadores activos: ", 1);
            sueldoMensual = LeerDouble("Ingrese el salario fijo por empleado (Q): ", 0);
            mesesRestantes = LeerEntero("Ingrese la duración de la simulación (Meses): ", 1);

            Console.WriteLine("\n--- Dimensiones de la Cuadrícula ---");
            filasTerreno = LeerEntero("Número de filas de parcelas: ", 1);
            columnasTerreno = LeerEntero("Número de columnas de parcelas: ", 1);
        }

        private void InicializarComponentes()
        {
            //catálogo de semillas con los datos de la tabla
            catalogoSemillas = new Cultivo[]
            {
                new Cultivo { Nombre = "Trigo",     TiempoCrecimiento = 1, CostoSemilla = 100, IngresoCosecha = 130,  InventarioDisponible = 0 },
                new Cultivo { Nombre = "Repollo",   TiempoCrecimiento = 2, CostoSemilla = 180, IngresoCosecha = 280,  InventarioDisponible = 0 },
                new Cultivo { Nombre = "Tomate",    TiempoCrecimiento = 3, CostoSemilla = 250, IngresoCosecha = 450,  InventarioDisponible = 0 },
                new Cultivo { Nombre = "Calabaza",  TiempoCrecimiento = 4, CostoSemilla = 220, IngresoCosecha = 360,  InventarioDisponible = 0 },
                new Cultivo { Nombre = "Espárrago", TiempoCrecimiento = 6, CostoSemilla = 500, IngresoCosecha = 1000, InventarioDisponible = 0 }
            };

            //inicialización de la matriz de parcelas
            matrizGranja = new Parcela[filasTerreno, columnasTerreno];
            for (int f = 0; f < filasTerreno; f++)
            {
                for (int c = 0; c < columnasTerreno; c++)
                {
                    matrizGranja[f, c] = new Parcela();
                }
            }
        }

        private void BuclePrincipal()
        {
            //el programa corre mientras queden meses y haya dinero en caja
            while (mesesRestantes > 0 && capitalDisponible > 0)
            {
                Console.Clear();
                Console.WriteLine($"=== ESTADO ACTUAL | Meses restantes: {mesesRestantes} | Caja: Q{capitalDisponible:F2} ===");
                Console.WriteLine("1. Adquirir insumos (Comprar Semillas)");
                Console.WriteLine("2. Sembrar en parcela");
                Console.WriteLine("3. Inspeccionar terreno (Consultar parcelas)");
                Console.WriteLine("4. Avanzar ciclo de tiempo (Siguiente Mes)");
                Console.WriteLine("5. Concluir simulación voluntariamente");

                int seleccion = LeerEntero("\nSeleccione una acción (1-5): ", 1, 5);
                Console.WriteLine();

                switch (seleccion)
                {
                    case 1: MenuComprarSemillas(); break;
                    case 2: AccionSembrar(); break;
                    case 3: AccionConsultarParcelas(); break;
                    case 4: AccionAvanzarMes(); break;
                    case 5: mesesRestantes = 0; break; // Termina la simulación
                }
            }
        }

        private void MenuComprarSemillas()
        {
            Console.WriteLine(">>> MENÚ DE COMPRA DE SEMILLAS <<<");
            double costosProyectados = totalEmpleados * sueldoMensual;
            double utilidadTeorica = capitalDisponible - costosProyectados;

            Console.WriteLine($"Efectivo en Caja: Q{capitalDisponible:F2}");
            Console.WriteLine($"Carga Financiera Laboral: Q{costosProyectados:F2}");
            Console.WriteLine($"Margen de Utilidad Proyectado: Q{utilidadTeorica:F2}");

            //restricción explícita de la página 2 del PDF
            if (utilidadTeorica < 0)
            {
                Console.WriteLine("\n[ALERTA] Operación denegada: La utilidad proyectada es negativa.");
                Console.WriteLine("Debe asegurar el pago de salarios antes de invertir en insumos.");
                PausarPantalla();
                return;
            }

            Console.WriteLine("\nVariedades en catálogo:");
            for (int i = 0; i < catalogoSemillas.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {catalogoSemillas[i].Nombre} (Costo: Q{catalogoSemillas[i].CostoSemilla} | Tiempo: {catalogoSemillas[i].TiempoCrecimiento} meses)");
            }

            int index = LeerEntero("\nSeleccione el tipo de planta: ", 1, catalogoSemillas.Length) - 1;
            int cantidadAComprar = LeerEntero("Escriba la cantidad de semillas que desea: ", 1);

            double inversionTotal = catalogoSemillas[index].CostoSemilla * cantidadAComprar;

            if (capitalDisponible >= inversionTotal)
            {
                capitalDisponible -= inversionTotal;
                catalogoSemillas[index].InventarioDisponible += cantidadAComprar;
                gastosMateriaPrima += inversionTotal;
                Console.WriteLine($"\n[ÉXITO] Transacción aprobada. Compró {cantidadAComprar} unidades de {catalogoSemillas[index].Nombre}.");
            }
            else
            {
                Console.WriteLine("\n[ERROR] Fondos monetarios insuficientes para completar este lote.");
            }
            PausarPantalla();
        }

        private void AccionSembrar()
        {
            Console.WriteLine(">>> OPERACIÓN DE SIEMBRA <<<");
            Console.WriteLine("Inventario actual disponible para uso:");
            for (int i = 0; i < catalogoSemillas.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {catalogoSemillas[i].Nombre}: {catalogoSemillas[i].InventarioDisponible} unidades.");
            }

            int index = LeerEntero("\nSeleccione la semilla que quiere plantar: ", 1, catalogoSemillas.Length) - 1;

            if (catalogoSemillas[index].InventarioDisponible <= 0)
            {
                Console.WriteLine($"\n[ERROR] No cuenta con existencias de {catalogoSemillas[index].Nombre} en bodega.");
                PausarPantalla();
                return;
            }

            int f = LeerEntero($"Indique la Fila (0 a {filasTerreno - 1}): ", 0, filasTerreno - 1);
            int c = LeerEntero($"Indique la Columna (0 a {columnasTerreno - 1}): ", 0, columnasTerreno - 1);

            if (matrizGranja[f, c].EstaOcupada)
            {
                Console.WriteLine("\n[AVISO] Zona no disponible: Esta parcela ya cuenta con un cultivo en desarrollo.");
            }
            else
            {
                //asignar datos de la planta elegida a la celda de la matriz
                matrizGranja[f, c].EstaOcupada = true;
                matrizGranja[f, c].TipoCultivo = catalogoSemillas[index].Nombre;
                matrizGranja[f, c].MesesFaltantes = catalogoSemillas[index].TiempoCrecimiento;
                matrizGranja[f, c].IngresoEsperado = catalogoSemillas[index].IngresoCosecha;

                catalogoSemillas[index].InventarioDisponible--; // Actualización de inventario
                Console.WriteLine($"\n[ÉXITO] Semilla de {catalogoSemillas[index].Nombre} plantada en la coordenada [{f}, {c}].");
            }
            PausarPantalla();
        }

        private void AccionConsultarParcelas()
        {
            Console.WriteLine(">>> MAPA GENERAL DEL TERRENO <<<");
            //renderizado visual de la cuadrícula
            for (int f = 0; f < filasTerreno; f++)
            {
                for (int c = 0; c < columnasTerreno; c++)
                {
                    Console.Write(matrizGranja[f, c].EstaOcupada ? "[OCUPADA]" : "[LIBRE] ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n--- Detalle específico de celda ---");
            int targetF = LeerEntero($"Fila a consultar (0 a {filasTerreno - 1}): ", 0, filasTerreno - 1);
            int targetC = LeerEntero($"Columna a consultar (0 a {columnasTerreno - 1}): ", 0, columnasTerreno - 1);

            Parcela p = matrizGranja[targetF, targetC];
            Console.WriteLine($"\nUbicación analizada: Fila {targetF}, Columna {targetC}");
            Console.WriteLine($"Estado de disponibilidad: " + (p.EstaOcupada ? "Ocupada" : "Libre"));

            if (p.EstaOcupada)
            {
                Console.WriteLine($"Variedad sembrada: {p.TipoCultivo}");
                Console.WriteLine($"Tiempo restante para maduración: {p.MesesFaltantes} mes(es)");
                Console.WriteLine($"Ingresos proyectados tras cosecha: Q{p.IngresoEsperado:F2}");
            }
            else
            {
                Console.WriteLine("Ingresos estimados para esta parcela: Q0.00");
            }
            PausarPantalla();
        }

        private void AccionAvanzarMes()
        {
            Console.WriteLine(">>> CRONOGRAMA: AVANZANDO AL SIGUIENTE MES <<<");

            // 1. Deducción y registro de nómina salarial
            double nominaMes = totalEmpleados * sueldoMensual;
            capitalDisponible -= nominaMes;
            gastosManoObra += nominaMes;
            mesesRestantes--;
            totalMesesSimulados++;

            Console.WriteLine($"• Desembolso por nómina de operarios: Q{nominaMes:F2}");
            Console.WriteLine($"• Capital restante en caja: Q{capitalDisponible:F2}\n");

            Console.WriteLine("--- Actualización de las parcelas ---");
            // 2. Iteración sobre la matriz para simular el transcurso biológico del cultivo
            for (int f = 0; f < filasTerreno; f++)
            {
                for (int c = 0; c < columnasTerreno; c++)
                {
                    if (matrizGranja[f, c].EstaOcupada)
                    {
                        matrizGranja[f, c].MesesFaltantes--;

                        if (matrizGranja[f, c].MesesFaltantes == 0)
                        {
                            // Cosecha madura y cobro automático
                            Console.WriteLine($"[COSECHA LISTA] ¡Parcela [{f}, {c}] completada! Se recolectó: {matrizGranja[f, c].TipoCultivo}. +Q{matrizGranja[f, c].IngresoEsperado}");
                            capitalDisponible += matrizGranja[f, c].IngresoEsperado;
                            ingresosPorCosechas += matrizGranja[f, c].IngresoEsperado;

                            // Liberar el suelo
                            matrizGranja[f, c].EstaOcupada = false;
                            matrizGranja[f, c].TipoCultivo = "Vacía";
                            matrizGranja[f, c].IngresoEsperado = 0;
                        }
                        else
                        {
                            Console.WriteLine($"Parcela [{f}, {c}]: Cultivo de {matrizGranja[f, c].TipoCultivo} en proceso. Faltan {matrizGranja[f, c].MesesFaltantes} meses.");
                        }
                    }
                }
            }
            PausarPantalla();
        }

        private void MostrarReporteFinal()
        {
            Console.Clear();
            Console.WriteLine("\n\tREPORTE DE CIERRE FINANCIERO DE LA GRANJA\n");

            //calcular Inventario en Proceso: El monto de ingresos esperados por plantas no cosechadas
            double inventarioEnProceso = 0;
            for (int f = 0; f < filasTerreno; f++)
            {
                for (int c = 0; c < columnasTerreno; c++)
                {
                    if (matrizGranja[f, c].EstaOcupada)
                    {
                        inventarioEnProceso += matrizGranja[f, c].IngresoEsperado;
                    }
                }
            }

            //aplicación matemática estricta de las ecuaciones de la página 3 del PDF:
            //mano de Obra Total = Total Empleados * Sueldo Mensual * Meses Simulados
            double manoObraCalculada = totalEmpleados * sueldoMensual * totalMesesSimulados;

            //utilidades = Capital Inicial + Ingresos + Inventario en Proceso - Mano de Obra - Materia Prima
            double utilidadesFinalesCalculadas = capitalInicial + ingresosPorCosechas + inventarioEnProceso - manoObraCalculada - gastosMateriaPrima;

            Console.WriteLine($"Capital de apertura (Inicial):       Q{capitalInicial:F2}");
            Console.WriteLine($"Ingresos liquidados por cosechas:    Q{ingresosPorCosechas:F2}");
            Console.WriteLine($"Inventario en desarrollo (Proceso):  Q{inventarioEnProceso:F2}");
            Console.WriteLine($"Costos totales de Mano de Obra:     Q{manoObraCalculada:F2}");
            Console.WriteLine($"Costos totales de Materia Prima:     Q{gastosMateriaPrima:F2}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Utilidades calculadas (Fórmula):     Q{utilidadesFinalesCalculadas:F2}");
            Console.WriteLine($"Efectivo real en caja:               Q{capitalDisponible:F2}");
            Console.WriteLine("==================================================");
            Console.WriteLine("Fin del simulador. Presione cualquier tecla para salir.");
            Console.ReadKey();
        }

        //métodos auxiliares robustos de validación
        private static int LeerEntero(string mensaje, int min = int.MinValue, int max = int.MaxValue)
        {
            int resultado;
            while (true)
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out resultado) && resultado >= min && resultado <= max)
                {
                    return resultado;
                }
                Console.Write("[Error] Formato de número entero inválido o fuera de rango. ");
            }
        }

        private static double LeerDouble(string mensaje, double min = double.MinValue)
        {
            double resultado;
            while (true)
            {
                Console.Write(mensaje);
                if (double.TryParse(Console.ReadLine(), out resultado) && resultado >= min)
                {
                    return resultado;
                }
                Console.Write("[Error] Formato decimal incorrecto o menor al límite permitido. ");
            }
        }

        private static void PausarPantalla()
        {
            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GranjaSimulator simulador = new GranjaSimulator();
            simulador.Iniciar();
        }
    }
}