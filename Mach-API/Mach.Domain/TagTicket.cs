using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mach.Domain
{
    public class TagTicket : BaseEntity
    {
        public Tag Tag { get; set; }
        public Ticket Ticket { get; set; }
    }
}