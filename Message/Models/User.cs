using System;
using System.Collections.ObjectModel;
using Message.Models;

namespace Message.Models
{
    public class User
    {
            public Guid Guid { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public DateTime LastUpdateTime { get; set; }
    }
}