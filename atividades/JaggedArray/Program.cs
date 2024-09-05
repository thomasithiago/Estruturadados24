// JegueArray é o array do Ceará
// JaggedArray é tambem conhecido como um vetor de Vetores 

int [][] numbers = new int[4][];

// Nesse caso [][] indica que é um vetor,nesse exemplo um vetor de 4 posições contendo vetores de tam indefinido 

numbers[0] = new int [] { 1, 2, 3 };
numbers[1] = new int [] { 4,3,2,1,0};
numbers[2] = new int [] { 1,2,0};
numbers[3] = new int [] { 57 } ;
numbers[4] = null; 

// Para obter valor de jaggedArray 
int valor = numbers[0][2];
Console.WriteLine(valor);

// Para atribuir valor em um jaggedArray 

numbers[1][2] =0;
Console.WriteLine( numbers [1][2] );