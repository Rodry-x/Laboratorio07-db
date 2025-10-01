namespace Listas.Cola
{
    internal class Cola
    {
        private Nodo? frente;
        private Nodo? final;

        private class Nodo
        {
            public double Valor { get; set; }
            public Nodo? Siguiente { get; set; }
            public Nodo(double valor)
            {
                Valor = valor;
                Siguiente = null;
            }
        }

        public Cola()
        {
            frente = null;
            final = null;
        }

        public bool EstaVacia()
        {
            return frente == null;
        }

        public void Encolar(double valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            if (EstaVacia())
            {
                frente = nuevoNodo;
                final = nuevoNodo;
            }
            else
            {
                final!.Siguiente = nuevoNodo;
                final = nuevoNodo;
            }
        }

        public double Desencolar()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La cola está vacía.");
            }
            double valor = frente!.Valor;
            frente = frente.Siguiente;
            if (frente == null)
            {
                final = null;
            }
            return valor;
        }

        public double VerFrente()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La cola está vacía.");
            }
            return frente!.Valor;
        }

        // Elimina todas las ocurrencias de un valor usando solo Encolar y Desencolar
        public void EliminarOcurrencias(double valor)
        {
            Cola colaAux = new Cola();
            while (!EstaVacia())
            {
                double actual = Desencolar();
                if (actual != valor)
                {
                    colaAux.Encolar(actual);
                }
            }
            // Restaurar los elementos a la cola original
            while (!colaAux.EstaVacia())
            {
                Encolar(colaAux.Desencolar());
            }
        }
    }
}
