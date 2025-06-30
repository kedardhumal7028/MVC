using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud_Operations.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Location { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}