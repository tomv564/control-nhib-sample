using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonq.Control.Entities
{
    /// <summary>
    /// Customer entity in Control.
    public class Customer
    {
        public virtual string Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Mobile { get; set; }
        public virtual Address InvoiceAddress { get; set; }
        public virtual Address DeliveryAddress { get; set; }
    }
}
