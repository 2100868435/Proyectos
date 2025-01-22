using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> listaPrimos = new LinkedList<int>();
        LinkedList<int> listaArmstrong = new LinkedList<int>();

        // Agregar números primos
        AgregarPrimos(listaPrimos, new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 });
        
        // Agregar números Armstrong
        AgregarArmstrong(listaArmstrong, new int[] { 0, 1, 153, 370, 371, 407 });

        // Mostrar resultados
        MostrarResultados(listaPrimos, listaArmstrong);
    }

    static void AgregarPrimos(LinkedList<int> lista, int[] primos)
    {
        foreach (var primo in primos)
        {
            lista.AddLast(primo);
        }
    }

    static void AgregarArmstrong(LinkedList<int> lista, int[] armstrong)
    {
        foreach (var num in armstrong)
        {
            lista.AddFirst(num);
        }
    }

    static void MostrarResultados(LinkedList<int> listaPrimos, LinkedList<int> listaArmstrong)
    {
        Console.WriteLine($"Número de primos: {listaPrimos.Count}");
        Console.WriteLine($"Número de Armstrong: {listaArmstrong.Count}");

        if (listaPrimos.Count > listaArmstrong.Count)
        {
            Console.WriteLine("La lista de números primos contiene más elementos.");
        }
        else if (listaArmstrong.Count > listaPrimos.Count)
        {
            Console.WriteLine("La lista de números Armstrong contiene más elementos.");
        }
        else
        {
            Console.WriteLine("Ambas listas contienen la misma cantidad de elementos.");
        }

        Console.WriteLine("\nElementos en la lista de números primos:");
        foreach (var primo in listaPrimos)
        {
            Console.WriteLine(primo);
        }

        Console.WriteLine("\nElementos en la lista de números Armstrong:");
        foreach (var armstrong in listaArmstrong)
        {
            Console.WriteLine(armstrong);
        }
    }
}