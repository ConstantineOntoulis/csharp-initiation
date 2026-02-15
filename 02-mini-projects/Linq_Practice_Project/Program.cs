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

        var openTickets = ticketData.Select(t => t.Status == "Open");

        foreach(var ticket in openTickets)
        {
            Console.WriteLine($"{ticket}");
        }

        Console.ReadKey();
    }
}