using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    /// <summary>
    /// Resuelve el problema de las Torres de Hanoi usando pilas.
    /// </summary>
    /// <param name="n">Número de discos</param>
    /// <param name="origen">Pila torre origen</param>
    /// <param name="destino">Pila torre destino</param>
    /// <param name="auxiliar">Pila torre auxiliar</param>
    /// <param name="nombreOrigen">Nombre torre origen</param>
    /// <param name="nombreDestino">Nombre torre destino</param>
    /// <param name="nombreAuxiliar">Nombre torre auxiliar</param>
    static void ResolverHanoi(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar,
                              string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
            return;
        }

        ResolverHanoi(n - 1, origen, auxiliar, destino,
                      nombreOrigen, nombreAuxiliar, nombreDestino);

        int discoActual = origen.Pop();
        destino.Push(discoActual);
        Console.WriteLine($"Mover disco {discoActual} de {nombreOrigen} a {nombreDestino}");

        ResolverHanoi(n - 1, auxiliar, destino, origen,
                      nombreAuxiliar, nombreDestino, nombreOrigen);
    }

    static void Main()
    {
        int discos = 3;

        Stack<int> torreA = new Stack<int>();
        Stack<int> torreB = new Stack<int>();
        Stack<int> torreC = new Stack<int>();

        // Inicializa la torre origen
        for (int i = discos; i >= 1; i--)
        {
            torreA.Push(i);
        }

        ResolverHanoi(discos, torreA, torreC, torreB,
                      "Torre A", "Torre C", "Torre B");
    }
} 
