using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mach.Domain
{
    public class Tag : BaseEntity
    {
        public IEnumerable<TagTicket> TagTickets { get; set; }
    }
}