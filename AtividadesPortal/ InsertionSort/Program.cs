using System;

public static class InsertionSort
{
    public static void Sort<T>(T[] array) where T : IComparable
    {
        for (int i = 1; i < array.Length; i++)
        {
            T key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j].CompareTo(key) > 0)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Quantos números você gostaria de inserir?");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Insira o número {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        InsertionSort.Sort(numbers);

        Console.WriteLine("Números ordenados:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
