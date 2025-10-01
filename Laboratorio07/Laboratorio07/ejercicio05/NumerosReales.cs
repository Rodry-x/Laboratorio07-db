using Listas.Cola;

namespace Laboratorio07.ejercicio05
{
    internal class NumerosReales
    {
        public void EjecutarEliminandoLosRepetidos()
        {
            Cola cola = new Cola();

            Console.Write("¿Cuántos números reales desea ingresar? ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el número real #{i + 1}: ");
                double numero = double.Parse(Console.ReadLine()!);
                cola.Encolar(numero);
            }

            Console.Write("Ingrese el valor a eliminar: ");
            double valorEliminar = double.Parse(Console.ReadLine()!);

            cola.EliminarOcurrencias(valorEliminar);

            Console.WriteLine("Cola después de eliminar las ocurrencias:");
            while (!cola.EstaVacia())
            {
                Console.WriteLine(cola.Desencolar());
            }
        }
    }
}
