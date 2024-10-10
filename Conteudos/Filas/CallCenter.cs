using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
using System.Threading.Tasks;
=======
>>>>>>> c44189c46f68edf658970a9f3b4f6a40896ed27a

namespace Filas
{
    public class CallCenter
    {
        private int _counter = 0;
<<<<<<< HEAD
        public Queue<IncomingCall>? Calls { get; set;} 

        public CallCenter()
        {

            Calls = new Queue<IncomingCall>();

        }

        // Método para Abertura de chamados 
        public void Call(int clientId)
        {
            IncomingCall call = new IncomingCall();
            {
                Id = ++_counter,
                clientId = clientId,
=======
        public Queue<IncomingCall> Calls { get; set; }
        
        public CallCenter()
        {
            Calls = new Queue<IncomingCall>();  
        }

        // Método para abertura de chamados
        public void Call(int clientId)
        {
            IncomingCall call = new IncomingCall()
            {
                id = ++_counter,
                ClientId = clientId,
>>>>>>> c44189c46f68edf658970a9f3b4f6a40896ed27a
                CallTime = DateTime.Now
            };

            Calls!.Enqueue(call);
<<<<<<< HEAD

        }

        

        

        public IncomingCall Asnwer(string consultant)
        {
            // Validação: Verificar se tem atendimento na fila 
            if(Calls!.Count >0)
            {
                IncomingCall call = Calls.Dequeue();
                call.Consultant = consultant;
                call.StartTime= DateTime.Now;

                return call;    
            }


            return null;
=======
        }

        public IncomingCall Answer(string consultant)
        {
            // Validação: verificar se tem atendimentos na Fila
            if(Calls.Count > 0)
            {
                IncomingCall call = Calls.Dequeue();
                call.Consultant = consultant;
                call.StartTime = DateTime.Now;

                return call;
            }
            
            return null!;        
>>>>>>> c44189c46f68edf658970a9f3b4f6a40896ed27a
        }

        public void End(IncomingCall call)
        {
<<<<<<< HEAD
            call.EndTime =DateTime.Now;
        }

        public bool AreWaintingCalls()
        {
         return (Calls!.count >0);
        }  

    }
=======
            call.EndTime = DateTime.Now;
        }

        public bool AreWaitingCalls()
        {
            return (Calls.Count > 0);
        }


    }


>>>>>>> c44189c46f68edf658970a9f3b4f6a40896ed27a
}