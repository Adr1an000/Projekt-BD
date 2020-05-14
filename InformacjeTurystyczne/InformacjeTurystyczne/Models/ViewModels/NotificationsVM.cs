using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models.InterfaceRepository;

namespace InformacjeTurystyczne.Models.ViewModels
{
    public class NotificationsVM
    {
        public IMessageRepository messages { get; set; }
    }
}
