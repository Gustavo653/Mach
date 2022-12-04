using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mach.Domain
{
    public class Ticket : BaseEntity
    {
        public IEnumerable<TagTicket> TagTickets { get; set; }
        public IEnumerable<Action> Actions { get; set; }
    }
}