using Listas.Cola;
using Listas.Pila;

namespace Laboratorio07.ejercicio09
{
    internal class InvertirOrden
    {
        public void EjecutarInvertirOrden()
        {
            Cola cola = new Cola();

            Console.Write("¿Cuántos elementos desea ingresar en la cola? ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Elemento #{i + 1}: ");
                double valor = double.Parse(Console.ReadLine()!);
                cola.Encolar(valor);
            }

            // Invertir la cola usando una pila
            Pila pila = new Pila();
            while (!cola.EstaVacia())
            {
                pila.Apilar(cola.Desencolar());
            }
            while (!pila.EstaVacia())
            {
                cola.Encolar(pila.Desapilar());
            }

            Console.WriteLine("Cola invertida:");
            while (!cola.EstaVacia())
            {
                Console.WriteLine(cola.Desencolar());
            }
        }
    }
}
