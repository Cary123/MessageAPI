using System;
using System.Collections.ObjectModel;
using Message.Models;

namespace Message.Models
{
    public class MailBox
    {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string DisplayName { get; set; }
            public string Username { get; set; }
            public long MaxSize { get; set; }
            public long AvailableSize { get;set; }
            public DateTime LastUpdateTime { get;set; }
            public Collection<Folder> Folders {get;set;}
    }
}