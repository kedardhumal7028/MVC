using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Crud_Operations.Models
{
    public class YourDbContext : DbContext
    {
        // DbSet for the Contact entity
        public DbSet<Contact> Contacts { get; set; }

        // Constructor to pass connection string to base DbContext
        public YourDbContext() : base("name=YourDbContext")
        {
        }
    }
}