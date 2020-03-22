using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class Message
    {
        public int Id { get; set; } // K

        public string Name { get; set; }
        public string Description { get; set; }

        [Timestamp]
        public byte[] PostingDate { get; set; }

        public int ID_Category { get; set; } // FK
        public int ID_Region { get; set; } // FK
    }
}
