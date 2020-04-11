using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    interface ISubscriptionRepository
    {
        IEnumerable<Subscription> GetAllSubscription();
        Subscription GetMessageByID(int ubscriptionID);

        void AddSubscription(Subscription subscription);
        void EditSubscription(Subscription subscription);
        void DeleteSubscription(Subscription subscription);
    }
}
