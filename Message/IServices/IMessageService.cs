using Message.Models;

namespace Message.IServices
{
    public interface IMessageService
    {
        void SendMessage(Message.Models.Message message);

        MailBox GetMailBoxByUser(string username);

        void DeleteMessage(Message.Models.Message message);
    }
}