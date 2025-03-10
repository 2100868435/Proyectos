using System;
using System.Collections.Generic;

namespace BibliotecaApp
{
    class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public Libro(string isbn, string titulo, string autor)
        {
            ISBN = isbn ?? throw new ArgumentNullException(nameof(isbn));
            Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
            Autor = autor ?? throw new ArgumentNullException(nameof(autor));
        }
    }

    class Biblioteca
    {
        private Dictionary<string, Libro> libros = new Dictionary<string, Libro>();

        public void AgregarLibro(string isbn, string titulo, string autor)
        {
            if (string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(autor))
            {
                Console.WriteLine("Error: Todos los campos deben estar llenos.");
                return;
            }
            
            if (!libros.ContainsKey(isbn))
            {
                libros[isbn] = new Libro(isbn, titulo, autor);
                Console.WriteLine("Libro agregado correctamente.");
            }
            else
            {
                Console.WriteLine("Error: Ya existe un libro con ese codigo ISBN.");
            }
        }

        public void EliminarLibro(string isbn)
        {
            if (string.IsNullOrEmpty(isbn) || !libros.ContainsKey(isbn))
            {
                Console.WriteLine("Error: ISBN no encontrado.");
                return;
            }
            libros.Remove(isbn);
            Console.WriteLine("Libro eliminado correctamente.");
        }

        public void ConsultarLibro(string isbn)
        {
            if (string.IsNullOrEmpty(isbn) || !libros.ContainsKey(isbn))
            {
                Console.WriteLine("Error: ISBN no encontrado.");
                return;
            }
            var libro = libros[isbn];
            Console.WriteLine($"ISBN: {libro.ISBN}\nTítulo: {libro.Titulo}\nAutor: {libro.Autor}");
        }

        public void MostrarLibros()
        {
            if (libros.Count == 0)
            {
                Console.WriteLine("No hay libros en la biblioteca.");
                return;
            }
            
            Console.WriteLine("Lista de libros:");
            foreach (var libro in libros.Values)
            {
                Console.WriteLine($"ISBN: {libro.ISBN}, Título: {libro.Titulo}, Autor: {libro.Autor}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var biblioteca = new Biblioteca();
            string opcion;

            do
            {
                Console.WriteLine("\nMenú Biblioteca  (J DIAZ - F CORRALES - N ANCHUNDIA)");
                Console.WriteLine("1. Agregar libro");
                Console.WriteLine("2. Eliminar libro");
                Console.WriteLine("3. Consultar libro");
                Console.WriteLine("4. Mostrar todos los libros");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine() ?? string.Empty; // Asegurarse de que opcion no sea nulo

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese codigo ISBN: ");
                        var isbn = Console.ReadLine() ?? string.Empty;
                        Console.Write("Ingrese Título: ");
                        var titulo = Console.ReadLine() ?? string.Empty;
                        Console.Write("Ingrese Autor: ");
                        var autor = Console.ReadLine() ?? string.Empty;
                        biblioteca.AgregarLibro(isbn, titulo, autor);
                        break;
                    case "2":
                        Console.Write("Ingrese ISBN del libro a eliminar: ");
                        var isbnEliminar = Console.ReadLine() ?? string.Empty;
                        biblioteca.EliminarLibro(isbnEliminar);
                        break;
                    case "3":
                        Console.Write("Ingrese ISBN del libro a consultar: ");
                        var isbnConsultar = Console.ReadLine() ?? string.Empty;
                        biblioteca.ConsultarLibro(isbnConsultar);
                        break;
                    case "4":
                        biblioteca.MostrarLibros();
                        break;
                    case "5":
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intente de nuevo.");
                        break;
                }
            } while (opcion != "5");
        }
    }
}