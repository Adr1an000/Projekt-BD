﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class Entertainment
    {
        [Key]
        public int IdEntertainment { get; set; } // K

        [Display(Name = "Nazwa imprezy")]
        public string Name { get; set; }

        [Display(Name = "Lokalizacja")]
        public string PlaceDescription { get; set; }

        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Display(Name = "Aktualna")]
        public bool UpToDate { get; set; }

        //[ForeignKey("Region")]
        public int IdRegion { get; set; }

        [Display(Name = "Region")]
        public Region Region { get; set; }

        public ICollection<PermissionEntertainment> PermissionEntertainment { get; set; }
    }
}
