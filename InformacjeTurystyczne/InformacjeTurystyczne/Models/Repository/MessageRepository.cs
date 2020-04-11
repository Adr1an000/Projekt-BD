using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InformacjeTurystyczne.Models.InterfaceRepository;

namespace InformacjeTurystyczne.Models.Repository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly AppDbContext _appDbContext;

        public MessageRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Message> GetAllMesage()
        {
            return _appDbContext.Messages;
        }

        public Message GetMessageByID(int messageID)
        {
            return _appDbContext.Messages.FirstOrDefault(s => s.IdMessage == messageID);
        }

        public void AddMessage(Message message)
        {
            _appDbContext.Messages.Add(message);
            _appDbContext.SaveChanges();
        }

        public void DeleteMessage(Message message)
        {
            _appDbContext.Messages.Remove(message);
            _appDbContext.SaveChanges();
        }

        public void EditMessage(Message message)
        {
            _appDbContext.Messages.Update(message);
            _appDbContext.SaveChanges();
        }
    }
}
