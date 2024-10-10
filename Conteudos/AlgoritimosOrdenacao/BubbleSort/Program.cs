
using BubbleSort;

int[] inteiros = {0,12,7,1,2,8};

Console.Write('[');

foreach(int i in inteiros)
{
    Console.Write(i," ");
}
  Console.Write(']');

BubbleSort.BubbleSort.Print<int>(inteiros);

Console.Writeline("Teste Char")

char[] chars = ['x' , 'z', 'b', 'c'];
BubbleSort.BubbleSort.Print(chars);
BubbleSort.BubbleSort.Sort(chars);
BubbleSort.BubbleSort.Print(chars);
