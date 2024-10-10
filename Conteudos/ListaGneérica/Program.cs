using ListaGenérica;

// Quando se coloca algo entre < >, é uma lista genérica
List<double> numbers = new List<double>();

do{
    Console.Write("Informe um número: ");

    // Validando a entrada do usuário
    string? numberStr = Console.ReadLine();

    // TryParse faz a conversão de string para double
    if (!double.TryParse(numberStr, out double number))
    break;

    numbers.Add(number);
    Console.WriteLine($"A Média dos valores é {numbers.Average()}");
}

while (true);

// Lista de pessoas
List <Person> people = new List<Person>();

Person p1 = new Person();
p1.Name = "Thiago";
p1.Age = 18;
p1.Country = CountryEnum.PY;
people.Add(p1);

p1.Name = "Jonas Junior da Silva Xavier";

people.Add(new Person(){
 Name = "Sharon Silva Xavier",
 Age = 67,
 Country = CountryEnum.PY
});

Person p3 = new Person(){
    Name = "Aroldo Churrasco",
    Age = 85,
    Country = CountryEnum.BR,
};
people.Add(p3);

// Percorrendo a lista
foreach (Person p in people){
    Console.WriteLine(p.Name);
}

// Outra forma de percorrer a lista
for (int i = 0; i < people.Count; i++){
    Console.WriteLine(people[i].Name);
    Console.WriteLine($"Nome: {people[i].Name}");
}