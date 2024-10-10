﻿// Basicamente as pilhas trabalham com uma estrutura LIFO
// Last In First Out - O último a entrar é o primeiro a sair

// Métodos de pilhas:
// Push() - Adiciona um elemento no topo da pilha
// Pop() - Remove o elemento do topo da pilha e o retorna
// Peek() - Retorna o elemento do topo da pilha sem removê-lo

Stack<char> caracteres = new Stack<char>();
    foreach (char c in "DARCY DA MONTANHA")
    {
        caracteres.Push(c);
    }

// Desempilhando
string invertido = string.Empty;
    while (caracteres.Count > 0)
    {
        invertido += caracteres.Pop();
    }
Console.WriteLine(invertido);