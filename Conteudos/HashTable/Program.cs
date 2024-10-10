using System;
using System.Collections;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable phoneBook = new Hashtable();

            phoneBook.Add("Thomasi", "149-99610150");
            phoneBook.Add("Thiago", "5498-46514");
            phoneBook.Add("Joao", "123-456");

            try
            {
                phoneBook.Add("Mary Fox", "789-987");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Este contato já existe!");
            }

            Console.WriteLine("Números de Telefone:");

            if (phoneBook.Count == 0)
            {
                Console.WriteLine("O catálogo está vazio!");
            }
            else
            {
                foreach (DictionaryEntry entry in phoneBook)
                {
                    Console.WriteLine($"{entry.Key} - {entry.Value}");
                }
            }

            while (true)
            {
                Console.WriteLine();
                Console.Write("Buscar por Nome (ou digite 'sair' para encerrar): ");
                string name = Console.ReadLine();

                // Verifica se o usuário digitou "sair"
                if (!string.IsNullOrEmpty(name) && name.Trim().Equals("sair", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Saindo...");
                    break;
                }

                string normalizedName = name.Trim().ToLower();

                bool found = false;
                foreach (string key in phoneBook.Keys)
                {
                    if (key.ToLower() == normalizedName)
                    {
                        string number = (string)phoneBook[key];
                        Console.WriteLine($"Número encontrado: {number}");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Esse contato não existe!");
                }
            }
        }
    }
}
