using System;
using System.Collections.Generic;

class Pessoa
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public List<Pessoa> Filhos { get; set; }

    public Pessoa(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
        Filhos = new List<Pessoa>();
    }

    public void AdicionarFilho(Pessoa filho)
    {
        Filhos.Add(filho);
    }

    public void Exibir(int nivel = 0)
    {
        Console.WriteLine(new string(' ', nivel * 2) + $"{Nome} - {Cargo}");
        foreach (var filho in Filhos)
        {
            filho.Exibir(nivel + 1);
        }
    }
}

class Program
{
    static void Main()
    {
        // Criando a árvore de pessoas
        Pessoa ceo = new Pessoa("Grazy", "CEO");
        Pessoa gerente1 = new Pessoa("Alexandre", "Gerente de Vendas");
        Pessoa gerente2 = new Pessoa("Evelyn", "Gerente de TI");

        Pessoa vendedor1 = new Pessoa("David", "Vendedor");
        Pessoa vendedor2 = new Pessoa("Gabriela", "Vendedora");

        Pessoa ti1 = new Pessoa("Mateus", "Analista de sistemas");
        Pessoa ti2 = new Pessoa("Thiago", "Analista de Infraestrutura");

        // Montando a estrutura
        ceo.AdicionarFilho(gerente1);
        ceo.AdicionarFilho(gerente2);

        gerente1.AdicionarFilho(vendedor1);
        gerente1.AdicionarFilho(vendedor2);

        gerente2.AdicionarFilho(ti1);
        gerente2.AdicionarFilho(ti2);

        // Exibindo a árvore
        ceo.Exibir();
    }
}
