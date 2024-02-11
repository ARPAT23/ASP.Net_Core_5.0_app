using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication3.Models;

namespace WebApplication3.ViewComponents
{
	public class CommentList : ViewComponent
    {
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					ID=1,
					Username="Serdar"
				},
				new UserComment
				{
					ID=2,
					Username="Kerim"
				},
				new UserComment
				{
					ID=3,
					Username="Merve"
				}
			};
			return View(commentvalues);
		}
	}
}
