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

public class CircularLinkedList
{
    private Node head; 
    private Node tail; 

    
    public CircularLinkedList()
    {
        head = null;
        tail = null;
    }

    
    public void AddLast(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            
            head = newNode;
            tail = newNode;
            tail.Next = head; 
        }
        else
        {
            tail.Next = newNode; 
            tail = newNode;     
            tail.Next = head;    
        }
    }

    
    public void AddFirst(int data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
            tail.Next = head; 
        }
        else
        {
            newNode.Next = head; 
            head = newNode;      
            tail.Next = head;    
        }
    }

    
    public void Remove(int data)
    {
        if (head == null)
        {
            Console.WriteLine("A lista está vazia.");
            return;
        }

        Node current = head;
        Node previous = tail; 

        
        if (head == tail && head.Data == data)
        {
            head = null;
            tail = null;
            return;
        }

      
        do
        {
            if (current.Data == data)
            {
                if (current == head)
                {
                    head = head.Next;
                    tail.Next = head; 
                }
                else if (current == tail)
                {
                    tail = previous;
                    tail.Next = head; 
                }
                else
                {
                    previous.Next = current.Next; 
                }
                return;
            }

            previous = current;
            current = current.Next;
        } while (current != head);

        Console.WriteLine("Valor não encontrado.");
    }
    
    public void PrintList()
    {
        if (head == null)
        {
            Console.WriteLine("A lista está vazia.");
            return;
        }

        Node current = head;
        do
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        } while (current != head);

        Console.WriteLine("(volta ao início)");
    }
}

class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList list = new CircularLinkedList();

        
        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);

        Console.WriteLine();

       
        Console.WriteLine("Lista atual:");
        list.PrintList();

        Console.WriteLine();

       
        list.AddFirst(5);
        Console.WriteLine("Lista após introduzir 5 no início:");
        list.PrintList();

        Console.WriteLine();

       
        list.Remove(20);
        Console.WriteLine("Lista após remover o valor 20:");
        list.PrintList();
        
        Console.WriteLine();

       
        list.Remove(5);
        Console.WriteLine("Após remover o valor 5:");
        list.PrintList();
    }
}


