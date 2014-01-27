using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonq.Control.Entities
{
    public class Address
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Street { get; set; }
        public virtual int HouseNo { get; set; }
        public virtual string HouseNoSuffix { get; set; }

        /// <summary>
        /// Note: Postalcode automaps to 'postalcode' column
        /// PostalCode automaps to 'postal_code' column.
        /// </summary>
        public virtual string Postalcode { get; set; }
        public virtual string City { get; set; }
    }
}
