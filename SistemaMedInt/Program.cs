using System;

namespace SistemaMedInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("  SISTEMA DE MEDICAMENTO INTELIGENTE ");
            Console.WriteLine("--------------------------------------------------------");
            
            SistemaMedicamento bombaInt = new SistemaMedicamento();

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine(" EVENTOS SIMULADOS:");
                Console.WriteLine(" 1. Iniciar Goteo           |Preparacion --> Proceso    |");
                Console.WriteLine(" 2. ¡Provocar Obstruccion!  |Proceso     --> Obstruccion|");
                Console.WriteLine(" 3. Resolver Falla Medica   |Obstruccion --> Proceso    |");
                Console.WriteLine(" 4. Pausar Infusion         |Proceso     --> Pausa      |");
                Console.WriteLine(" 5. Reanudar Infusion       |Pausa       --> Proceso    |");
                Console.WriteLine(" 6. Terminar Dosis          |Proceso     --> Terminado  |");
                Console.WriteLine(" 7. Reiniciar Maquina       |Terminado   --> Preparación|");
                Console.WriteLine(" 8. Apagar Máquina y Salir");
                Console.Write("\n Ingrese el número del evento a simular: ");

                string opcion = Console.ReadLine();
                Console.WriteLine(); 

                switch (opcion)
                {
                    case "1": bombaInt.IniciarGoteo(); break;
                    case "2": bombaInt.DetectarFalla(); break;
                    case "3": bombaInt.ResolverFalla(); break;
                    case "4": bombaInt.Pausar(); break;
                    case "5": bombaInt.Reanudar(); break; 
                    case "6": bombaInt.DosisCompletada(); break;
                    case "7": bombaInt.Reiniciar(); break;
                    case "8": 
                        salir = true; 
                        Console.WriteLine(" Apagando..."); 
                        break;
                    default:
                        Console.WriteLine(" [X] Opcion no valida.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\n Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}