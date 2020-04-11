using InformacjeTurystyczne.Models.Tabels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.InterfaceRepository
{
    public interface IMessageRepository
    {
        IEnumerable<Message> GetAllMesage();
        Message GetMessageByID(int messageID);

        void AddMessage(Message message);
        void EditMessage(Message message);
        void DeleteMessage(Message message);
    }
}
