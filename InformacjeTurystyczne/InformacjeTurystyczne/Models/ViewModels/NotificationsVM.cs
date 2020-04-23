using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.ViewModels
{
    public class NotificationsVM
    {
        public struct Subscription
        {
            public string Region { get; set; }
            public bool Notification { get; set; }
        }
        public List<Subscription> Subscriptions { get; set; }
        public List<string> Types { get; set; }
        public List<MessageVM> Messages { get; set; }
    }
}
