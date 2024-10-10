using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    // Esta fila representa a fila de chamados de um Callcenter 
    public class IncomingCall
    {
        
=======

namespace Filas
{
    // Esta classe representa a Fila de Chamados em um CallCenter
    public class IncomingCall
    {
>>>>>>> c44189c46f68edf658970a9f3b4f6a40896ed27a
        public int id { get; set; }
        public int ClientId { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
<<<<<<< HEAD
        public string? Consultant { get; set; }        
    }

=======
        public string? Consultant { get; set; }

    }


>>>>>>> c44189c46f68edf658970a9f3b4f6a40896ed27a
}