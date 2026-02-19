using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Linq_Practice_Project
{
    internal enum TicketStatus
    {
        Open,
        InProgress,
        Closed
    }
    internal class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TicketStatus Status { get; set; }
        public DateTime Date { get; set; }

        public Ticket(int id, string name, TicketStatus status, DateTime date)
        {
            Id = id;
            Name = name;
            Status = status;
            Date = date;
        }
    }

}
