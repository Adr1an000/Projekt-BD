using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    public interface ISubscriptionRepository
    {
        IEnumerable<Subscription> GetAllSubscription();
        Subscription GetSubscriptionByID(int ubscriptionID);

        void AddSubscription(Subscription subscription);
        void EditSubscription(Subscription subscription);
        void DeleteSubscription(Subscription subscription);
    }
}
