using Mach.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mach.Domain
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public User CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public User ChangedBy { get; set; }
        public DateTime ChangedDate { get; set; }
    }
}
