using System;

namespace SimuladorDado
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            
            Console.Write("Ingrese el número de veces que desea lanzar el dado: ");
            if (int.TryParse(Console.ReadLine(), out int numLanzamientos) && numLanzamientos > 0)
            {
                int[] resultados = new int[6]; // Se inicializa un arreglo para contar las caras del dado (del 1 al 6)

                for (int i = 0; i < numLanzamientos; i++)
                {
                    int resultado = rand.Next(1, 7); // Se Simuló el lanzamiento del dado
                    resultados[resultado - 1]++; // Se incrementa el contador de la cara obtenida
                }

                // Se imprime los resultados
                for (int cara = 0; cara < 6; cara++)
                {
                    Console.WriteLine($"Cara {cara + 1}: {resultados[cara]} veces");
                }
            }
            else
            {
                Console.WriteLine("Ingrese un número válido y mayor que cero.");
            }
        }
    }
}