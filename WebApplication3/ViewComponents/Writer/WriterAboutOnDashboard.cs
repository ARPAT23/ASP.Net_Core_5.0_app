using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApplication3.ViewComponents.Writer
{
   
    public class WriterAboutOnDashboard : ViewComponent
    {
		WriterManager wm = new WriterManager(new EfWriterRepository());
		Context c = new Context();

		public IViewComponentResult Invoke()
        {
			var userName = User.Identity.Name;
			ViewBag.user = userName;
			var usermail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
			var writerId = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
			var values = wm.GetWriterById(writerId);
			return View(values);
		}
    }
}
