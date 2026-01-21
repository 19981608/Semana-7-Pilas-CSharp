using System;
using System.Collections.Generic;

class BalanceoParentesis
{
    static void Main()
    {
        string expresion = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";

        Console.WriteLine("Expresión evaluada:");
        Console.WriteLine(expresion);

        bool balanceada = VerificarBalanceo(expresion);

        if (balanceada)
        {
            Console.WriteLine("Resultado: Fórmula balanceada.");
        }
        else
        {
            Console.WriteLine("Resultado: Fórmula NO balanceada.");
        }
    }

    static bool VerificarBalanceo(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                pila.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (pila.Count == 0)
                    return false;

                char ultimo = pila.Pop();

                if (!Coinciden(ultimo, c))
                    return false;
            }
        }

        return pila.Count == 0;
    }

    static bool Coinciden(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '[' && cierre == ']') ||
               (apertura == '{' && cierre == '}');
    }
}

