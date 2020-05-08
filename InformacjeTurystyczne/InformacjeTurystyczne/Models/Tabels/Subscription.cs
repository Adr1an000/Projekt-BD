using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class Subscription
    {
        [Key]
        public int IdSubscription { get; set; }

        [Display(Name = "Zasubskrybowano")]
        public bool IsSubscribed { get; set; }

      //  [ForeignKey("Region")]
        public int IdRegion { get; set; }
        public virtual Region Region { get; set; }

        public string IdUser { get; set; }
        public virtual AppUser User { get; set; }
    }
}
