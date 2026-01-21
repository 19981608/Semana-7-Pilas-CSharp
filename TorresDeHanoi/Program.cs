using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int totalDiscos = 3;

        Stack<int> origen = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();
        Stack<int> destino = new Stack<int>();

        for (int i = totalDiscos; i >= 1; i--)
        {
            origen.Push(i);
        }

        Console.WriteLine("Resolución de las Torres de Hanoi:\n");

        ResolverHanoi(totalDiscos, origen, destino, auxiliar,
                      "Origen", "Destino", "Auxiliar");

        Console.WriteLine("\nProceso finalizado.");
    }

    static void ResolverHanoi(int n,
                              Stack<int> origen,
                              Stack<int> destino,
                              Stack<int> auxiliar,
                              string nombreOrigen,
                              string nombreDestino,
                              string nombreAuxiliar)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine("Mover disco " + disco +
                              " de " + nombreOrigen +
                              " a " + nombreDestino);
            return;
        }

        ResolverHanoi(n - 1, origen, auxiliar, destino,
                      nombreOrigen, nombreAuxiliar, nombreDestino);

        int discoActual = origen.Pop();
        destino.Push(discoActual);
        Console.WriteLine("Mover disco " + discoActual +
                          " de " + nombreOrigen +
                          " a " + nombreDestino);

        ResolverHanoi(n - 1, auxiliar, destino, origen,
                      nombreAuxiliar, nombreDestino, nombreOrigen);
    }
}
