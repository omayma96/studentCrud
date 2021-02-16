using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspCrud.Models
{
    public class Item
    {
        [Key]

        public int id { get; set; }
        public string nom { get; set; }

        public string prenom { get; set; }

        public string cin { get; set; }

        public string adress { get; set; }
    }
}
