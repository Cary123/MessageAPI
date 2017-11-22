using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Message.Services;
using Message.Models;
using Message.Common;
namespace Message.Controllers
{
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        
        // GET api/message
        [HttpGet]
        public IActionResult Get()
        {
            return Json(Guid.NewGuid().ToString()+"||"+Guid.NewGuid().ToString()+Guid.NewGuid().ToString());
        }

        // GET api/message/5
        [HttpGet("{username}")]
        public IActionResult Get(string username)
        {
            ReturnResult result = new ReturnResult();
            MailBox mailBox = null;
            try
            {
                mailBox = new MessageService().GetMailBoxByUser(username);
                result.ResultCode = 1;
                result.Content = mailBox;
            }
            catch (Exception e)
            {
                result.ResultCode = 0;
                result.Message = e.ToString();
            }
            return Json(result);
        }

        // POST api/message
        [HttpPost]
        public IActionResult Post([FromBody]Message.Models.Message message)
        {
            if (message != null)
            {
                new MessageService().SendMessage(message);
            }
            return Json("111");
        }

        // PUT api/message/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/message/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
