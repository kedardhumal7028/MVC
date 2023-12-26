using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Domain
{
    public class Genere
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
