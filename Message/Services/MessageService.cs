using System;
using Message.Models;
using Message.IServices;
using Message.DAL;
namespace Message.Services
{
    public class MessageService : IMessageService
    {
        public void SendMessage(Message.Models.Message message)
        {

        }

        public MailBox GetMailBoxByUser(string username)
        {
           return MessageDAL.GetMailBoxByUser(username);
        }

        public void DeleteMessage(Message.Models.Message message)
        {
            
        }
    }
}