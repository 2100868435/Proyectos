using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese una palabra
        Console.Write("Introduce una palabra: ");
        string palabra = Console.ReadLine();

        // Llamar a la función para verificar si es un palíndromo
        if (EsPalindromo(palabra))
        {
            Console.WriteLine($"La palabra '{palabra}' es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"La palabra '{palabra}' no es un palíndromo.");
        }
    }

    // Función que verifica si una palabra es un palíndromo
    static bool EsPalindromo(string palabra)
    {
        // Normalizar la palabra: quitar espacios y convertir a minúsculas
        string palabraNormalizada = palabra.Replace(" ", "").ToLower();

        // Invertir la palabra
        char[] arrayPalabra = palabraNormalizada.ToCharArray();
        Array.Reverse(arrayPalabra);
        string palabraInvertida = new string(arrayPalabra);

        // Comparar la palabra normalizada con la invertida
        return palabraNormalizada == palabraInvertida;
    }
}