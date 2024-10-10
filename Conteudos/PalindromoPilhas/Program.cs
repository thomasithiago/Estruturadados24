Console.WriteLine("PILHA QUE DESCOBRE SE SUA PALAVRA É UM PALÍNDROMO!");
Console.WriteLine("Digite uma palavra: ");
    string? palavra = Console.ReadLine();

Stack<char> caracteres = new Stack<char>();
    foreach (char c in palavra)
    {
        caracteres.Push(c);
    }

string invertido = string.Empty;
    while (caracteres.Count > 0)
    {
        invertido += caracteres.Pop();
    }


Console.Write("\nSua Palavra invertida é:\n");
Console.WriteLine(invertido);

if(palavra == invertido)
    {
        Console.WriteLine("Sua palavra é um palíndromo!");
    }
    else{
        Console.WriteLine("Sua palavra não é um palíndromo!");
    }