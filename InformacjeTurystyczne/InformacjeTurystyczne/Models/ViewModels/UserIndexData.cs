﻿using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.ViewModels
{
    public class UserIndexData
    {
        public IEnumerable<AppUser> Users { get; set; }
        public IEnumerable<Region> Regions { get; set; }
        public IEnumerable<Shelter> Shelters { get; set; }
        public IEnumerable<Trial> Trials { get; set; }
        public IEnumerable<Entertainment> Entertainments { get; set; }
    }
}
