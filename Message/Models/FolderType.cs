using System;
using Message.Models;

namespace Message.Models
{
    public enum FolderType
    {
        Inbox,
        Outbox,
        Sent,
        Draft,
        Trash,
        Save,
        Personal
    }
}