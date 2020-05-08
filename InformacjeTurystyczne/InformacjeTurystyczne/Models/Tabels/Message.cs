using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class Message
    {
        [Key]
        public int IdMessage { get; set; } // K

        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Display(Name = "Treść")]
        public string Description { get; set; }

        [Display(Name = "Data zapostowania")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PostingDate1 { get; set; }

        //[ForeignKey("Category")]
        public int? IdCategory { get; set; }
        public Category Category { get; set; }

        //[ForeignKey("Region")]
        public int? IdRegion { get; set; }
        public virtual Region Region { get; set; }
    }
}
