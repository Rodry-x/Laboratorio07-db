namespace Listas.Pila
{
    internal class Pila
    {
        private Nodo? cima;
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
        public Pila()
        {
            cima = null;
        }
        public bool EstaVacia()
        {
            return cima == null;
        }
        public void Apilar(double valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            nuevoNodo.Siguiente = cima;
            cima = nuevoNodo;
        }
        public double Desapilar()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La pila está vacía.");
            }
            double valor = cima!.Valor;
            cima = cima.Siguiente;
            return valor;
        }
        public double VerCima()
        {
            if (EstaVacia())
            {
                throw new InvalidOperationException("La pila está vacía.");
            }
            return cima!.Valor;
        }
    }
}
