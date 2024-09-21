using System;

public class Node
{
    
    public int Data; 
    public Node Next; 

    
    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}


public class LinkedList
{
    private Node head; 

    
    public LinkedList()
    {
        head = null;
    }
    
    public void AddLast(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }


    
    public void AddFirst(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            newNode.Next = head;
            head = newNode;
        }
    }

    
    public void Remove(int data)
    {
        if (head == null)
        {
            Console.WriteLine("A lista está vazia.");
            return;
        }

        if (head.Data == data)
        {
            head = head.Next;
            return;
        }

        Node current = head;
        Node previous = null;

        while (current != null && current.Data != data)
        {
            previous = current;
            current = current.Next;
        }

        if (current == null)
        {
            Console.WriteLine("Valor não encontrado.");
            return;
        }

        previous.Next = current.Next;
    }
    public void PrintList()
    {
        if (head == null)
        {
            Console.WriteLine("A lista está vazia.");
            return;
        }

        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}


class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        list.AddLast(20);
        list.AddLast(30);
        list.AddLast(40);

        Console.WriteLine("Lista atual:");
        list.PrintList();

        Console.WriteLine();

        Console.WriteLine();

        list.AddFirst(10);
        Console.WriteLine("Lista após adicionar 10 no início:");
        list.PrintList();

        Console.WriteLine();
        
        list.Remove(20);
        Console.WriteLine("Lista após remover o valor 20:");
        list.PrintList();
    }
}
