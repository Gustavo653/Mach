using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mach.Domain
{
    public class Action : BaseEntity
    {
        public Ticket Ticket { get; set; }
    }
}