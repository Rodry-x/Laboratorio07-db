using Laboratorio07.ejercicio05;
using Laboratorio07.ejercicio07;
using Laboratorio07.ejercicio08;
using Laboratorio07.ejercicio09;

namespace Laboratorio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("| Menu para seleccionar el ejercicio |");
                Console.WriteLine("======================================");
                Console.WriteLine("| 1. Eliminar números repetidos      |");
                Console.WriteLine("| 2. Verificar Palindromos           |");
                Console.WriteLine("| 3. Verificar Capicúa               |");
                Console.WriteLine("| 4. Invertir orden de la cola       |");
                Console.WriteLine("--------------------------------------");
                Console.Write("Seleccione una opción (1-5): ");
                string opcion = Console.ReadLine()!;

                switch (opcion)
                {
                    case "1":
                        NumerosReales numerosReales = new NumerosReales();
                        numerosReales.EjecutarEliminandoLosRepetidos();
                        break;
                    case "2":
                        Palindromo palindromos = new Palindromo();
                        palindromos.EjecutarVerificarPalindromo();
                        break;
                    case "3":
                        Capicua capicua = new Capicua();
                        capicua.EjecutarVerificarCapicua();
                        break;
                    case "4":
                        InvertirOrden invertirCola = new InvertirOrden();
                        invertirCola.EjecutarInvertirOrden();
                        break;
                }

                Console.WriteLine();
                Console.Write("¿Desea continuar? (s/n): ");
                string respuesta = Console.ReadLine()!.Trim().ToLower();
                continuar = (respuesta == "s" || respuesta == "si");
            }
        }
    }
}
