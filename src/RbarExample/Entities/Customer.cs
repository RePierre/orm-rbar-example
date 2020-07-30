using System;
using System.Text;

namespace RbarExample.Entities
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }
    }
}
