using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InformacjeTurystyczne.Models.InterfaceRepository;
using InformacjeTurystyczne.Models.Tabels;

namespace InformacjeTurystyczne.Models.Repository
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly AppDbContext _appDbContext;

        public SubscriptionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Subscription> GetAllSubscription()
        {
            return _appDbContext.Subscriptions;
        }

        public Subscription GetMessageByID(int subscriptionID)
        {
            return _appDbContext.Subscriptions.FirstOrDefault(s => s.IdSubscription == subscriptionID);
        }

        public void AddSubscription(Subscription subscription)
        {
            _appDbContext.Subscriptions.Add(subscription);
            _appDbContext.SaveChanges();
        }

        public void DeleteSubscription(Subscription subscription)
        {
            _appDbContext.Subscriptions.Remove(subscription);
            _appDbContext.SaveChanges();
        }

        public void EditSubscription(Subscription subscription)
        {
            _appDbContext.Subscriptions.Update(subscription);
            _appDbContext.SaveChanges();
        }
    }
}
