﻿// Comentario de uma linha 
/* 

  Comentario de 
  Multiplas linhas 

*/

// Declarando variaveis 

using Aula01;

int number;

// Atribuindo valor 
number = 10; 


// Declarando constante
const int DAYS_IN_WEEK = 7;

// IMPRIMINDO STRING CONCATENADA

Console.WriteLine($"a semana tem {DAYS_IN_WEEK} dias.");

// new TipoEnumerador() -> Invoca o método construtor do objeto
// Toda Classe tem o seu construtor padrão implicito sem argumentos 
// Todavia,se fizermos,perdemos o original implicito e 
// precisaremos defini-lo explicitamente 

TipoEnumerador tipoEnum = new TipoEnumerador();

TipoEnumerador.Language enumEnglish = 
tipoEnum.GetLanguageEnum("inglês"); 

Console.WriteLine( $"O Enum de english é {enumEnglish}" );



