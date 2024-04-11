using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{

    public class MessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        Context c = new Context();
        private readonly Microsoft.AspNetCore.Identity.UserManager<AppUser> _userManager;
      
        public IActionResult InBox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = mm.GetInboxListByWriter(writerID);
            //if (values.Count() > 3)
            //{
            //    values = values.TakeLast(3).ToList();
            //}
            return View(values);
        }

        public IActionResult SendBox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = mm.GetSendboxListByWriter(writerID);
            return View(values);
        }

        public IActionResult MessageDetail(int id)
        {
            var value = mm.TGetById(id);
            return View(value);
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message2 p)
        {

            Message2 message = new Message2();
            

            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();

            p.SenderID = writerID;
            p.ReceiverID = 4;
            p.MessageStatus = false;
            p.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            mm.TAdd(p);
            return RedirectToAction("Inbox");
        }


        public IActionResult DeleteMessage(int id)
        {

            var value = mm.TGetById(id);
            if (value.IsDelete)
            {
                value.IsDelete = false;
            }
            else
            {
                value.IsDelete = true;
            }
            mm.TUpdate(value);
            return RedirectToAction("Inbox");
        }
    }
}