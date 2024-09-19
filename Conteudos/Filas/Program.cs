// Uma fila é a estrutura de dados que pode ser aplicada para representar a fila de atendimento da cantina 
// As pessoas que chegam,entram no final da fila 
// E as primeiras que chegaram sao as primeiras a serem atendidas.

// A função ENQUEUE é responsavel por adicionar novos elementos a fila 
// A função DEQUEUE remove elementos da fila.

// Desta forma obedece o principio do FIFO 
//First in, First Out --> Primeiro que entra é o primeiro que sai 
using Filas;

Random random = new Random();

CallCenter center = new();
center.Call(1234);
center.Call(1269);
center.Call(2468);
center.Call(1478);

while(center.AreWaintingCalls())
{
    Thread.Sleep(3000);
    IncomingCall call = center.Answer("Thiago");
    Console.WriteLine(@$"{DateTime.Now:HH:mm:ss} Chamado: #{call.id}
    De: {call.ClientId}
    Atendido por : {call.Consultant}"
    );
    Thread.Sleep(random.Next(1000, 10000));
    center.End(call);
    Console.WriteLine(
        @$"Chamado: {call.Id}
        Encerrado ás: {call.EndTime}"
    
    );
}
