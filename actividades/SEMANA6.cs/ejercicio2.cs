using System;

public class Nodo<T>
{
    public T Valor { get; set; }
    public Nodo<T> Siguiente { get; set; }

    public Nodo(T valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

public class ListaEnlazada<T>
{
    private Nodo<T> cabeza;

    public void AgregarAlFinal(T valor)
    {
        Nodo<T> nuevoNodo = new Nodo<T>(valor);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo<T> actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }

    public void Invertir()
    {
        Nodo<T> anterior = null;
        Nodo<T> actual = cabeza;
        Nodo<T> siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Siguiente; // Guardar el siguiente nodo
            actual.Siguiente = anterior;   // Invertir el enlace
            anterior = actual;             // Mover el anterior hacia adelante
            actual = siguiente;            // Mover el actual hacia adelante
        }
        cabeza = anterior; // Actualizar la cabeza de la lista
    }

    public void Mostrar()
    {
        Nodo<T> actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada<int> lista = new ListaEnlazada<int>();
        
        // Agregar elementos a la lista
        lista.AgregarAlFinal(1);
        lista.AgregarAlFinal(2);
        lista.AgregarAlFinal(3);
        lista.AgregarAlFinal(4);
        lista.AgregarAlFinal(5);

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        // Invertir la lista
        lista.Invertir();

        Console.WriteLine("Lista invertida:");
        lista.Mostrar();
    }
}