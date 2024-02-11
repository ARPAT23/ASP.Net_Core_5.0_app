using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	internal class NewsLetterManager : INewsLetterService
	{
		INewsLetterDal _newsletterDal;

		public NewsLetterManager(INewsLetterDal newsLetterDal)
		{
			_newsletterDal = newsLetterDal;
		}

		public void AddNewsLetters(NewsLetter newsLetter)
		{
			_newsletterDal.Insert(newsLetter);
		}
	}
}
