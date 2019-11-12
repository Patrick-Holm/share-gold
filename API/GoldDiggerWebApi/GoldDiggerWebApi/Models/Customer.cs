using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldDiggerWebApi.Models
{
    public class Customer
    {
        public Customer()
        {
        }
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        public string PhoneNumber { get; set; }

        public string MailAdress { get; set; }

        public string MemberKey { get; set; }

        public DateTime MemberDate { get; set; }




    }
}
