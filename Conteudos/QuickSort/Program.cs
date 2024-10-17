﻿using QuickSort;

Console.WriteLine("Testando o Quick Sort: ");

int[] values = new int[] {0, 15, 24, 1, 3, 6, 12, 9};

QuickSort.QuickSort.Print<int> (values);
Console.WriteLine("Iniciando Ordenação: ");
QuickSort.QuickSort.Sort<int>(values, 0, values.Length - 1);
Console.WriteLine("Finalizando Ordenação: ");
QuickSort.QuickSort.Print<int>(values);