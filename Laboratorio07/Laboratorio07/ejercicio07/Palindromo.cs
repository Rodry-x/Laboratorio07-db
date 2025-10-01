using Listas.Pila;
using Listas.Cola;

namespace Laboratorio07.ejercicio07
{
    internal class Palindromo
    {
        public void EjecutarVerificarPalindromo()
        {
            Console.Write("Ingrese una palabra o frase: ");
            string entrada = Console.ReadLine()!;

            // Normalizar: quitar espacios y pasar a minúsculas
            string normalizada = "";
            foreach (char c in entrada)
            {
                if (!char.IsWhiteSpace(c))
                    normalizada += char.ToLower(c);
            }

            Pila pila = new Pila();
            Cola cola = new Cola();

            // Apilar y encolar cada carácter (como double)
            foreach (char c in normalizada)
            {
                pila.Apilar(c);
                cola.Encolar(c);
            }

            bool esPalindromo = true;
            while (!pila.EstaVacia() && !cola.EstaVacia())
            {
                char desdePila = (char)pila.Desapilar();
                char desdeCola = (char)cola.Desencolar();
                if (desdePila != desdeCola)
                {
                    esPalindromo = false;
                    break;
                }
            }

            if (esPalindromo)
                Console.WriteLine("La palabra/frase es palíndromo.");
            else
                Console.WriteLine("Esta palabra/frase no es palíndromo.");
        }
    }
}
