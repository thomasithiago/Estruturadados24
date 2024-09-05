using System.Collections;

//Utilizando a Lista Simples 
ArrayList arrList = new ();
arrList.Add(5);
arrList.Add("Thiago");
// É possivel aidiconar um conjunto de valores de uma só vez 
arrList.AddRange(new int [] { 1, 2, 3});
// o método .Add() insere o valor ao fial do vetor 
arrList.Insert(2, 15);
// Já o metodo inseert me permite incluior o valor desejado na posição especificada no primeiro parâmetro;

//Lendo valores da Lista 
object primeiro = arrList[0]!;
int quarto = (int)arrList[3]!;

// Percorrendo a lista com foreach 
foreach(object obj in arrList)
{
  
   Console.Write($" | {obj}");

}

//obtendo o tamanho total da lista 

int tamanho = arrList.Count;
// Obter a capacidade 
// Quandos podem ser armazenados 
int capacidade = arrList.Capacity;

// Percorrendo no modo Clássico 
for(int i =0; i < arrList.Count; i++)
{
    Console.Write( $" | {arrList[i]}" );
}

// Recursos importantes da Lista 
// Veirificar se um valor é contido na lista 

bool contemNome = arrList.Contains("Thiago");
if(!contemNome )
  Console.WriteLine("Nome Thiago não encontrado");

  

   // Para saber se o índice que contem o valor buscado 
   // Neste caso se ovalor existir na lista 
   // Ela reotorna o índice (número inteiro)
   // Caso o valor não exista na lista, retorna -1
   int indiceValor =
     arrList.IndexOf("Thiago");
     if(indiceValor >= 0)
        Console.WriteLine( $"Thiago está em [{indiceValor}]");
        else 

        Console.WriteLine("É, realmente não tem");

        //É possivel remover itens da lista 
        arrList.Remove("Thiago");
        arrList.RemoveAt(4);
        arrList.RemoveRange(0,2);