 using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{

	
	public class WriterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
        UserManager userManager = new UserManager(new EfUserRepository());

        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
		public IActionResult Index()
		{
			var usermail = User.Identity.Name;
			ViewBag.mailName = usermail;
            Context c = new Context();
			var writerName = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterName).FirstOrDefault();
			ViewBag.writerName = writerName;
			return View();
		}
		public IActionResult WriterProfile()
		{
			return View();
		}
	
		public IActionResult WriterMail()
		{
			return View();
		}
		[AllowAnonymous]
		public IActionResult Test()
		{
			return View();
		}
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
		{
			return PartialView();
		}
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
		{
			return PartialView();
		}
       
		[HttpGet]
        public async Task<IActionResult> WriterEditProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
			UserUpdateModel model = new UserUpdateModel();

			model.username = values.UserName;
			model.namesurname = values.NameSurname;
			model.imageurl = values.ImageUrl;
			model.phone = values.PhoneNumber;
			model.mail = values.Email;

			return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(UserUpdateModel model)
		{

			//UserManager userManager = new UserManager(new EfUserRepository());


			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			/// model.username = values.UserName;
			//ViewBag.userName = values;
			values.NameSurname = model.namesurname;
			values.ImageUrl = model.imageurl;
			values.Email = model.mail;
            // values.UserName = model.username;
            //values.PhoneNumber = model.phone;
            //if (model.password != null)
            //{
            if (!model.changepassword)
            {
                values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.password);
            }

			//}
			var result = await _userManager.UpdateAsync(values);
			//return RedirectToAction("WriterEdit", "Writer");

			return RedirectToAction("Index", "Dashboard");

		}
		[AllowAnonymous]
		[HttpGet]
		public IActionResult WriterAdd()
		{
			return View();
		}
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
			Writer w = new Writer();
			if (p.WriterImage != null)
			{
				var extension = Path.GetExtension(p.WriterImage.FileName);
				var newimagename = Guid.NewGuid() + extension;
				var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFile/", newimagename);
				var stream = new FileStream(location, FileMode.Create);
				p.WriterImage.CopyTo(stream);
				w.WriterImage = newimagename;

			}
			w.WriterMail = p.WriterMail;
			w.WriterName = p.WriterName;
			w.WriterPassword = p.WriterPassword;
			w.WriterStatus = true;
			w.WriterAbout = p.WriterAbout;
			wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");

        }

		
    }
}
