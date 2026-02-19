using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Linq_Practice_Project
{
    internal class TicketDB
    {
        public static List<Ticket> GetTicketData()
        {
            return new List<Ticket>()
            {
                new Ticket(1, "Login fails on invalid password", TicketStatus.Open, DateTime.Today.AddDays(-1)),
                new Ticket(2, "Add pagination to tickets endpoint", TicketStatus.Open, DateTime.Today.AddDays(-3)),
                new Ticket(3, "Fix N+1 query in comments", TicketStatus.Open, DateTime.Today.AddDays(-12)),

                new Ticket(4, "Refactor DTO mapping", TicketStatus.InProgress, DateTime.Today.AddDays(-2)),
                new Ticket(5, "Update Docker compose", TicketStatus.InProgress, DateTime.Today.AddDays(-9)),

                new Ticket(6, "Improve validation messages", TicketStatus.Closed, DateTime.Today.AddDays(-5)),
                new Ticket(7, "Add role-based authorization", TicketStatus.Closed, DateTime.Today.AddDays(-15)),

                new Ticket(8, "Fix timezone bug", TicketStatus.Open, DateTime.Today.AddDays(-20)),
            };
        }
    }
}
