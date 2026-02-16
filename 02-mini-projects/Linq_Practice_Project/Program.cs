using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Linq_Practice_Project;

public static class Program
{
    public static void Main()
    {
        var ticketData = TicketDB.GetTicketData();

        var openTickets = ticketData.Where(t => t.Status == "Open").ToList();

        Console.WriteLine("The open tickets are:" );
        Console.WriteLine();

        Console.WriteLine($"OPEN COUNT: {openTickets.Count}");

        foreach (var ticket in openTickets)
        {
            Console.WriteLine($"{ticket.Name}");
        }

        Console.ReadKey();
    }
}