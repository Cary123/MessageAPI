Email For Practice
====================

## Key Words
1.[Dotnet Core](https://dotnet.github.io/)
2.[Restful](http://www.runoob.com/w3cnote/restful-architecture.html)
3.[MongoDB](https://www.mongodb.com/download-center)
4.[Redis](https://redis.io/)
5.[ELK](https://www.elastic.co/)

====================

## Struct
![mahua](Description\Email System.png)

====================
## Dotnet Core


## Restful


## MongoDB


## Redis


## ELK


## Meta Data

```javascript
  message -> mailbox
{
  "Id": "E2A66291-7B16-CE3A-6F8D-0F194A8E08EE",
  "Name":"UserMailBox",
  "DisplayName":"UserMailBox",
  "UserName":"Joseph",
  "MaxSize":1099511627776,
  "AvailableSize":1099511627776,
  "LastUpdateTime": "2017:11:11 11:11:11:100"
}

message -> folder
{
    "Id":"580A56AB-802F-2D44-EF05-09FF57C4FC30",
    "Name":"Inbox",
    "DisplayName":"Inbox",
    "Type":"InBox",
    "MessageCount":0,
    "MailBoxId":"E2A66291-7B16-CE3A-6F8D-0F194A8E08EE",
    "LastUpdateTime":"2017:11:11 11:11:11:100"
}

message -> message
{
    "Id":"27C15195-0AD4-63CF-7DB4-6B65494E8111",
    "Subject":"HelloWorld",
    "Content":"How are you?",
    "SendTime":"2017:11:11 11:11:11:100",
    "State":"Unread",
    "FromAddress":"Joseph@Joseph.com",
    "ToAddress":"Peter@Joseph.com;Bill@Joseph.com",
    "CcAddress":"Tom@Joseph.com;Kathy@Joseph.com",
    "OriginalFolderId":"580A56AB-802F-2D44-EF05-09FF57C4FC30",
    "CurrentFolderId":"580A56AB-802F-2D44-EF05-09FF57C4FC30",
    "LastUpdateTime":"2017:11:11 11:11:11:100"
}

message -> users
{
    "Id":"580A56AB-802F-2D44-EF05-09FF57C4FC30",
    "Username":"Joseph",
    "Password":"123456",
    "LastUpdateTime":"2017:11:11 11:11:11:100"
}

message -> userSession
{
    "SessionId":"6B503F43-E4AC-7F60-4A84-A021C01FA21F",
    "Username":"Joseph",
    "State":"Online",
    "LastUpdateTime":"2017:11:11 11:11:11:100"
}

```
