TerrenoEnum[,] mapa = {
    { TerrenoEnum.Grama, TerrenoEnum.Grama, TerrenoEnum.Grama,
        TerrenoEnum.Grama, TerrenoEnum.Grama, TerrenoEnum.Grama,
        TerrenoEnum.Grama, TerrenoEnum.Grama, TerrenoEnum.Grama,
        TerrenoEnum.Grama}, 
    {
        TerrenoEnum.Grama, TerrenoEnum.Água, TerrenoEnum.Água,
        TerrenoEnum.Grama, TerrenoEnum.Água, TerrenoEnum.Grama,
        TerrenoEnum.Grama, TerrenoEnum.Grama, TerrenoEnum.Água,
        TerrenoEnum.Grama},
    {
        TerrenoEnum.Grama, TerrenoEnum.Grama, TerrenoEnum.Grama,
        TerrenoEnum.Água, TerrenoEnum.Grama, TerrenoEnum.Água,
        TerrenoEnum.Água, TerrenoEnum.Grama, TerrenoEnum.Grama,
        TerrenoEnum.Grama},
    
    {
        TerrenoEnum.Grama, TerrenoEnum.Grama, TerrenoEnum.Grama,
        TerrenoEnum.Grama, TerrenoEnum.Água, TerrenoEnum.Água,
        TerrenoEnum.Água, TerrenoEnum.Terra, TerrenoEnum.Terra,
        TerrenoEnum.Terra},
    
    {
        TerrenoEnum.Terra, TerrenoEnum.Terra, TerrenoEnum.Fogo,
        TerrenoEnum.Terra, TerrenoEnum.Fogo, TerrenoEnum.Terra,
        TerrenoEnum.Fogo, TerrenoEnum.Fogo, TerrenoEnum.Terra,
        TerrenoEnum.Terra},
    
    {
        TerrenoEnum.Fogo, TerrenoEnum.Fogo, TerrenoEnum.Fogo,
        TerrenoEnum.Fogo, TerrenoEnum.Fogo, TerrenoEnum.Fogo,
        TerrenoEnum.Fogo, TerrenoEnum.Fogo, TerrenoEnum.Fogo,
        TerrenoEnum.Fogo},
};

Console.OutputEncoding  = System.Text.Encoding.UTF8;

for(int linhas = 0; linhas < mapa.GetLength(0); linhas++)
{
    for(int colunas = 0; colunas < mapa.GetLength(1); colunas++)
    {
        Console.ForegroundColor = mapa[linhas, colunas].GetColor();
        Console.Write(mapa[linhas, colunas].GetChar() + " ");
    }
    Console.WriteLine();
}
Console.ForegroundColor = ConsoleColor.White;