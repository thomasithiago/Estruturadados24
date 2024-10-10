﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Pagina
{
    // Propriedade para armazenar o conteúdo da página
    public string Content { get; set; }
}

class Program
{
    static void Main()
    {
        // Criação de páginas a partir da Classe e Propriedade
        Pagina paginaFirst = new Pagina() { Content = "Este é o exemplo da Primeira página. Esse código pode\napresentar uma página de um livro ou um documento. Para\ncriar uma página,você precisa criar uma instância da classe\nPagina e atribuir um valor para a propriedade Content.\n\n" };
        Pagina paginaSecond = new Pagina() { Content = "Este é o exemplo da Segunda página. Esse código pode\napresentar uma página de um livro ou um documento. Para\ncriar uma página,você precisa criar uma instância da classe\nPagina e atribuir um valor para a propriedade Content.\n\n" };
        Pagina paginaThird = new Pagina() { Content = "Este é o exemplo da Terceira página. Esse código pode\napresentar uma página de um livro ou um documento. Para\ncriar uma página,você precisa criar uma instância da classe\nPagina e atribuir um valor para a propriedade Content.\n\n" };
        Pagina paginaFourth = new Pagina() { Content = "Este é o exemplo da Quarta página. Esse código pode\napresentar uma página de um livro ou um documento. Para\ncriar uma página,você precisa criar uma instância da classe\nPagina e atribuir um valor para a propriedade Content.\n\n" };
        Pagina paginaFifth = new Pagina() { Content = "Criado por Thiago Wurster Balbinot\nAula de Estrutura De Dados\nSegundo Semestre Ciência da Computação UNOESC\n\n" };

        // Criação da Lista Linkada para mostrar a ordem das Páginas
        LinkedList<Pagina> paginas = new LinkedList<Pagina>();
        paginas.AddLast(paginaSecond);

        // Criação de um nó na Lista Linkada
        LinkedListNode<Pagina> nodePaginaThird = paginas.AddLast(paginaThird);
        paginas.AddLast(paginaFifth);
        paginas.AddFirst(paginaFirst);
        paginas.AddAfter(nodePaginaThird, paginaFourth);

        // Exibição da ordem das Páginas, bem como sua representação na tela e o conteúdo
        LinkedListNode<Pagina> paginaAtual = paginas.First;

        // Número que representa a primeira página
        int number = 1;

        // Loop que percorre enquanto as páginas não forem nulas
        while (paginaAtual != null)
        {
            Console.Clear();
            string numberString = $"-*- {number} -*-";
            int espacamento = (90 - numberString.Length) / 2;
            Console.WriteLine(numberString.PadLeft(espacamento + numberString.Length));
            Console.WriteLine();

            string content = paginaAtual.Value.Content;

            // Linhas que representam a página, juntamente com Thread.Sleep para dar um efeito de escrita
            for(int i = 0; i < content.Length; i++)
            {
                string character = content[i].ToString();
                Console.Write(character);
                Thread.Sleep(1);

            }
            

            Console.WriteLine();

            // Exibição dos botões de navegação
            Console.Write(paginaAtual.Previous != null ? "<ANTERIOR [A]>" : GetSpaces(14));
            Console.Write(paginaAtual.Next != null ? "<PRÓXIMO [D]>" : GetSpaces(14));
            Console.WriteLine();
            Console.WriteLine("\n\nPressione qualquer tecla para sair...");

            // Programa faz a leitura da tecla pressionada (Avançar ou Voltar)
            switch(Console.ReadKey (true).Key)
            {
                case ConsoleKey.D:

                if (paginaAtual.Next != null)
                {
                    paginaAtual = paginaAtual.Next;
                    number++;
                }
                break;

                case ConsoleKey.A:

                if( paginaAtual.Previous != null)
                {
                    paginaAtual = paginaAtual.Previous;
                    number--;
                }
                break;

                default:
                return;
            }

        }

        
    }

    // Classe que ajusta o espaço entre as linhas
    static string GetSpaces(int length)
    {
    return new string(' ', length);
    }
}

