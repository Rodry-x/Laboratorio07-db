using Listas.Pila;
using Listas.Cola;

namespace Laboratorio07.ejercicio08
{
    internal class Capicua
    {
        public void EjecutarVerificarCapicua()
        {
            Console.Write("Ingrese un número entero: ");
            string entrada = Console.ReadLine()!;

            // Opcional: eliminar espacios y validar que solo sean dígitos
            string numero = entrada.Trim();

            Pila pila = new Pila();
            Cola cola = new Cola();

            // Apilar y encolar cada dígito
            foreach (char c in numero)
            {
                if (char.IsDigit(c))
                {
                    double digito = c - '0';
                    pila.Apilar(digito);
                    cola.Encolar(digito);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Solo se permiten números.");
                    return;
                }
            }

            bool esCapicua = true;
            while (!pila.EstaVacia() && !cola.EstaVacia())
            {
                double desdePila = pila.Desapilar();
                double desdeCola = cola.Desencolar();
                if (desdePila != desdeCola)
                {
                    esCapicua = false;
                    break;
                }
            }

            if (esCapicua)
                Console.WriteLine("El número es capicúa.");
            else
                Console.WriteLine("El número no es capicúa.");
        }
    }
}
