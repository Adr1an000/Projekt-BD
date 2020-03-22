using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Repository
{
    public class MessageRepository
    {
        private readonly AppDbContext _appDbContext;

        public MessageRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Message> GetAllMessage()
        {
            return _appDbContext.Messages;
        }

        public Message GetMessageByID(int messageID)
        {
            return _appDbContext.Messages.FirstOrDefault(s => s.Id == messageID);
        }
    }
}
