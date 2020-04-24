using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.ViewModels
{
    public class TouristInformationVM
    {
        //Lista nazw regionów
        public List<string> Regions { get; set; }
        //Lista rodzajów rozrywek: szlak, schronisko, impreza, muzeum itp.
        public List<string> Types { get; set; }
        //Lista Rozrywek (InfoRecord)
        //InfoRecord to lista właściwości danego obiektu
        public List<InfoRecordVM> Records { get; set; }

        public TouristInformationVM()
        {
            Regions = new List<string>();
            Types = new List<string>();
            Records = new List<InfoRecordVM>();
        }
    }
}
