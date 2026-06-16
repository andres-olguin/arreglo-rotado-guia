using System;

class Program
{
    static void Main(string[] args)
    {
        // Nuestro tren de ejemplo: [21, 38, 45, 2, 16]
        int[] arregloRotado = { 21, 38, 45, 2, 16 };

        Console.WriteLine("--- Iniciando Búsqueda del Mínimo ---");
        
        int posicionMinimo = BuscarPosicionMinimo(arregloRotado);
        int valorMinimo = arregloRotado[posicionMinimo];

        Console.WriteLine($"\nResultado Final:");
        Console.WriteLine($"- El número más pequeño está en la posición: {posicionMinimo}");
        Console.WriteLine($"- El valor que está dentro de esa posición es: {valorMinimo}");
    }

    static int BuscarPosicionMinimo(int[] A)
    {
        int inicio = 0;
        int fin = A.Length - 1; // Para 5 elementos, fin será 4

        while (inicio < fin)
        {
            int centro = (inicio + fin) / 2;

            Console.WriteLine($"\nVuelta del ciclo:");
            Console.WriteLine($"  * inicio = {inicio}, fin = {fin}, centro = {centro}");
            Console.WriteLine($"  * Comparando: A[centro] ({A[centro]}) > A[fin] ({A[fin]})");

            if (A[centro] > A[fin])
            {
                Console.WriteLine("  * Resultado: VERDADERO. El mínimo está a la derecha.");
                inicio = centro + 1;
            }
            else
            {
                Console.WriteLine("  * Resultado: FALSO. El mínimo está a la izquierda o es el centro.");
                fin = centro;
            }
        }

        // Cuando inicio y fin son iguales, encontramos la posición
        return inicio;
    }
}
