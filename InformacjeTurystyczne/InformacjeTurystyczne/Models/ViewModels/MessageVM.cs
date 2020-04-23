using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.ViewModels
{
    public class MessageVM
    {
        public struct Property
        {
            public string Value { get; set; }
        }
        public Dictionary<string, Property> Properties { get; set; }
    }
}
