using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApplication3.Controllers
{
	//[Authorize(Roles = "Admin,Moderator,Writer")]
	public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());

		public IActionResult Index()
        {
			Context c = new Context();
			var username = User.Identity.Name;
			var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
			var writerid = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
			ViewBag.ToplamBlogSayisi = c.Blogs.Count().ToString();
			ViewBag.YazarinBlogSayisi = c.Blogs.Where(x => x.WriterID == writerid).Count();
			ViewBag.KategoriSayisi = c.Categories.Count();
			return View();
		}
    }
}
