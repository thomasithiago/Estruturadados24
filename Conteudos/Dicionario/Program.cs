// Diferente da TabelaHash, O Dictionary nos permite expecificar o tipo de dado que sera utulizado nos PARES 
// Key --. Value 
//Isso nos fornece uma estrutura fortemente tipada 

Dictionary<string, string> dictionary = new Dictionary<string, string>();
{
   {"Chave 1" , "Valor 1"}
   {"Chave 2" , "Valor 2"}

};

//Obter o valor do dictionary 
string val = dictionary["Chave 1"];

try
{
    val = dictionary["Chave 3"];

}
catch (Exception ex)
{
    Console.WriteLine("Eroo ao obter valor da Chave 3");
    Console.WriteLine(ex.Message);
}

if(dictionary.ContainsKey("Chave 2"))

{

    Console.WriteLine($"Chave 2: {dictionary["Chave 2"]}");

}

//Outra forma de obter um valor e evitar erro

var valor = dictionary.TryGetValue("Chave 4" , out string? valor);
if val(valor is not null)
     Console.WriteLine($"Chave 4: {dictionary["Chave 4"]}");

//Podemos adcionar da mesma foram pela chave inexistente 
dictionary ["Chave 0"] = "Valor 0";

foreach(KeyValuePair<string, string> kvp in dictionary)
{
  Console.WriteLine($"{kvp.Key}:{kvp.Value}");   
}

dictionary<int , Pessoa> dicPessoa =
 new dictionary<int, Pessoa>();

 dicPessoa.Add(
    1,
    new Pessoa () {
        id = 0,
        BirthDate = new DateTime (2005 ,6 ,6 ),
        nameof = "Thiago Thomasi"
    }
 );