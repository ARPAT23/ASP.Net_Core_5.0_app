using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminMessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        Context c = new Context();
        private readonly Microsoft.AspNetCore.Identity.UserManager<AppUser> _userManager;
        public AdminMessageController(Microsoft.AspNetCore.Identity.UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult InBox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = mm.GetInboxListByWriter(writerID);
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
        [HttpGet]
        public IActionResult ComposeMessage()
        {

            return View();
        }
        [HttpPost]
        public IActionResult ComposeMessage(SendMessageModelView model)
        {
            Message2 message = new Message2();
            var reciever = _userManager.FindByEmailAsync(model.Email);

            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            message.SenderID = writerID;
            message.ReceiverID = reciever.Id;
            message.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            message.MessageStatus = true;
            message.Subject = model.Subject;
            message.MessageDetails = model.Detail;
            message.IsDelete = false;
            mm.TAdd(message);



            return RedirectToAction("SendBox", "AdminMessage");
        }

        public async Task<IActionResult> MessageDetail(int id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var inboxMessageCount = mm.GetInboxListByWriter(user.Id).Count();
            var sendMessageCount = mm.GetSendboxListByWriter(user.Id).Count();
            ViewBag.imc = inboxMessageCount;
            ViewBag.smc = sendMessageCount;

            var value = mm.TGetById(id);
            if (value.MessageStatus == false)
            {
                value.MessageStatus = true;
                mm.TUpdate(value);
            }

            return View(value);
        }


    }
}