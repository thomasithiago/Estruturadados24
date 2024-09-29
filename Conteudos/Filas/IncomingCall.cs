using System;

namespace Filas
{
    // Esta classe representa a Fila de Chamados em um CallCenter
    public class IncomingCall
    {
        public int id { get; set; }
        public int ClientId { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Consultant { get; set; }

    }


}