
using System.Data;
using System.Reflection.Metadata.Ecma335;
using Aula02;

Person person = new Person();
Console.WriteLine(person.Name);

Person person1
 = new Person("Thiago Thomasi", 19);
Console.WriteLine(person1.Name);

Person person2 =new Person();
person2.Name = "Vladmir Lich Ullyanov";
person2.Age = 70;
Console.WriteLine(person2.Name);

Person person3 = new Person()
{

    Name = "Leonel Brizola",
    Age = 80 

};
Console.WriteLine(person3.Name);