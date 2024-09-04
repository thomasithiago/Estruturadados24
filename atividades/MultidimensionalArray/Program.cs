// Criando um vetor muntidimensional 
// Com5 linhas e 2 colunas 

int [,] numbers = new int [5,2];

// Criando um vetor tridimensional 
int[,,] triNumbers = new int [5,4,3];

// Podemos inicializar ps valores dp vetor no momento de sua declaração 
int[,] iniNumbers = new int [,] 
{
    {9,15,-9},
    {4,3,-9},
    {8,5,3},
    {2,1,3},
    {3,1,-4},

};

// Para acessar ps vaçpres contidos nesse tipo de variavel 
int valor = iniNumbers[0,1]; // Neste caso =15 

Console.WriteLine( $"iniNumbers[0,1] = {valor}"); 

int Maiornumero = iniNumbers [0,0];

foreach (int number in iniNumbers)
{

    if (number > Maiornumero)
     
     {
        Maiornumero = number;
     }

}    

Console.WriteLine( "o maior número é:" + Maiornumero);