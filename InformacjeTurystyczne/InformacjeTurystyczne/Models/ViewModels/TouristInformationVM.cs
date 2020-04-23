using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.ViewModels
{
    public class TouristInformationVM
    {
        public List<string> Regions { get; set; }
        public List<string> Types { get; set; }
        public List<MessageVM> Messages { get; set; }
    }
}
