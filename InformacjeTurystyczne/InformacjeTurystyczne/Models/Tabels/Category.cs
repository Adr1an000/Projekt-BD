using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; } // K

        public string Name { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}
