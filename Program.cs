class Program
{
    // Catálogo de revistas de Ecuador
    // Se inicializa con 15 revistas como ejemplo
    static List<string> catalogo = new List<string>
    {
        "Vistazo",
        "Revista Líderes",
        "Gestión",
        "Mundo Diners",
        "La Casa",
        "América Economía Ecuador",
        "Revista Fucsia Ecuador",
        "Clubes",
        "Revista Vive",
        "Hogar",
        "Revista Gestión Ambiental",
        "Ekos",
        "Revista Anaconda",
        "Revista La Tierra",
        "Revista Mundo Agropecuario"
    };

    static void Main(string[] args)
    {
        int opcion; // Variable para controlar la opción del menú
        do
        {
            // Menú principal
            Console.Clear();
            Console.WriteLine("=== CATÁLOGO DE REVISTAS ECUATORIANAS ===");
            Console.WriteLine("1. Buscar revista");
            Console.WriteLine("2. Mostrar todas las revistas");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine()); // Lee la opción del usuario

            switch (opcion)
            {
                case 1:
                    // Buscar una revista en el catálogo
                    Console.Write("Ingrese el título a buscar: ");
                    string titulo = Console.ReadLine();
                    
                    // Llamada al método de búsqueda recursiva
                    bool encontrado = BuscarRecursivo(catalogo, titulo, 0);

                    // Mostrar resultado
                    if (encontrado)
                        Console.WriteLine("\nResultado: Encontrado");
                    else
                        Console.WriteLine("\nResultado: No encontrado");
                    
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey(); // Pausa para que el usuario lea el mensaje
                    break;

                case 2:
                    // Mostrar todas las revistas del catálogo
                    Console.WriteLine("\nCatálogo completo:");
                    foreach (var revista in catalogo)
                    {
                        Console.WriteLine("- " + revista);
                    }
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                    break;

                case 3:
                    // Salida del programa
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    // Opción inválida
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 3); // Repite el menú hasta que el usuario elija salir
    }

    // Método de búsqueda recursiva
    static bool BuscarRecursivo(List<string> lista, string titulo, int indice)
    {
        if (indice >= lista.Count)
            return false;

        // Comparar el elemento actual con el título buscado (ignora mayúsculas/minúsculas)
        if (lista[indice].Equals(titulo, StringComparison.OrdinalIgnoreCase))
            return true; // Se encontró

        // Llamada recursiva: pasar al siguiente índice
        return BuscarRecursivo(lista, titulo, indice + 1);
    }
}
