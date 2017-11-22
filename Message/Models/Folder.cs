using System;
using System.Collections.ObjectModel;
using Message.Models;

namespace Message.Models
{
    public class Folder
    {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string DisplayName { get; set; }
            public string Type { get; set; }
            public long MessageCount { get; set; }
            public Guid MailBoxId { get;set; }
            public DateTime LastUpdateTime { get;set; }
            public Collection<Message> Messages { get; set; }

    }
}