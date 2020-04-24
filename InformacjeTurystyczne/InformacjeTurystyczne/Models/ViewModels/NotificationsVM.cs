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
        //lista subskrypcji danego użytkownika
        public List<Subscription> Subscriptions { get; set; }
        //lista typów obiektów
        public List<string> Types { get; set; }
        //Lista nazw regionów
        public List<string> Regions { get; set; }
        //Lista wiadomości
        public List<InfoRecordVM> Messages { get; set; }
    }
}
