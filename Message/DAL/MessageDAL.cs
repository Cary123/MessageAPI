using System;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Core;
using Message.Models;
using System.Collections.ObjectModel;
namespace Message.DAL
{
    public class MessageDAL
    {
        public static void AddMessage(Message.Models.Message message)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("message");
            var collection = database.GetCollection<BsonDocument>("message");
            var filter = new BsonDocument();
            var list = collection.Find(filter).ToList();

            foreach (var document in list)
            {
                Console.WriteLine(document["Name"]);
            }
        }

        public static MailBox GetMailBoxByUser(string username)
        {
            MailBox mailBox = new MailBox();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("message");
            var mailBoxCollection = database.GetCollection<BsonDocument>("mailbox");
            var folderCollection = database.GetCollection<BsonDocument>("folder");
            var messageCollection = database.GetCollection<BsonDocument>("message");
            var mailboxBuilder = Builders<BsonDocument>.Filter;
            var mailBoxFilter = mailboxBuilder.Eq("UserName",username);
            var mailBoxList = mailBoxCollection.Find(mailBoxFilter).ToList();

            foreach (var doc in mailBoxList)
            {
                mailBox.Name = doc["Name"].AsString;
                mailBox.DisplayName = doc["DisplayName"].AsString;
                mailBox.Username =doc["UserName"].AsString;
                mailBox.Id = new Guid(doc["Id"].AsString);
                mailBox.MaxSize = (long)doc["MaxSize"].AsDouble;
                mailBox.AvailableSize = (long)doc["AvailableSize"].AsDouble;
                //mailBox.LastUpdateTime = Convert.ToDateTime(doc["LastUpdateTime"].AsString);
                mailBox.Folders = new Collection<Folder>();
                var folderBuilder = Builders<BsonDocument>.Filter;
                var folderFilter = folderBuilder.Eq("MailBoxId",mailBox.Id.ToString().ToUpper());
                var folderList = folderCollection.Find(folderFilter).ToList();
                foreach (var folderDoc in folderList)
                {
                    Folder folder = new Folder();
                    folder.Id = new Guid(folderDoc["Id"].AsString);
                    folder.Name = folderDoc["Name"].AsString;
                    folder.DisplayName = folderDoc["DiaplayName"].AsString;
                    folder.Type = folderDoc["Type"].AsString;
                    folder.MessageCount = (long)folderDoc["MessageCount"].AsDouble;
                    folder.MailBoxId = new Guid(folderDoc["MailBoxId"].AsString);
                   // folder.LastUpdateTime =Convert.ToDateTime(folderDoc["LastUpdateTime"].AsString);
                    folder.Messages = new Collection<Message.Models.Message>();
                    var messageBuilder = Builders<BsonDocument>.Filter;
                    var messageFilter = messageBuilder.Eq("CurrentFolderId",folder.Id.ToString().ToUpper());
                    var messageList = messageCollection.Find(messageFilter).ToList();
                    foreach (var messageDoc in messageList)
                    {
                        Message.Models.Message message = new Message.Models.Message();
                        message.Id = new Guid(messageDoc["Id"].AsString);
                        message.Subject = messageDoc["Subject"].AsString;
                        message.Content = messageDoc["Content"].AsString;
                      //  message.SendTime = Convert.ToDateTime(messageDoc["SendTime"].AsString);
                        message.Sender = new Contact();
                        message.Sender.EmailAddress = messageDoc["FromAddress"].AsString;
                        message.ToRecipient = new Collection<Contact>();
                        Contact contact = new Contact();
                        contact.EmailAddress = messageDoc["ToAddress"].AsString;
                        message.ToRecipient.Add(contact);
                        message.OriginalFolderId = new Guid(messageDoc["OriginalFolderId"].AsString);
                        message.CurrentFolderId = new Guid(messageDoc["CurrentFolderId"].AsString);
                      //  message.LastUpdateTime = Convert.ToDateTime(messageDoc["LastUpdateTime"].AsString);
                        folder.Messages.Add(message);
                    }
                    mailBox.Folders.Add(folder);
                }
            }
            return mailBox;
        }
    }
}