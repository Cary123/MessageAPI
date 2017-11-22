using System;
using System.Collections.ObjectModel;
using Message.Models;

namespace Message.Models
{
    public class Message
    {
            public Guid Id { get; set; }
            public string Subject { get; set; }
            public string Content { get; set; }
            public DateTime SendTime { get; set; }
            public MessageState State { get; set; }
            public virtual Contact Sender { get; set; }
            public virtual Collection<Contact> ToRecipient { get; set; }
            public virtual Collection<Contact> CcRecipient { get; set; }
            public Guid OriginalFolderId { get;set; }
            public Guid CurrentFolderId { get;set; }
            public DateTime LastUpdateTime { get;set; }
            
    }
}