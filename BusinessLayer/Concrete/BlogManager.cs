﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}


		public List<Blog> GetBlogListWithCategory()
		{
			return _blogDal.GetlistWithCategory();
		}
		public List<Blog> GetListWithCategoryByWriterBm(int id)
		{
			return _blogDal.GetListWithCategoryByWriter(id);
		}

		public Blog TGetById(int id)
		{
			return _blogDal.GetByID(id);
		}
		public List<Blog> GetBlogByID(int id)
		{
			return _blogDal.GetListAll(x=>x.BlogID==id);
		}

		public List<Blog> GetList()
		{
			return _blogDal.GetListAll();
		}

		public List<Blog> GetLast3Blog()
		{
			return _blogDal.GetListAll().Take(3).ToList();
		}

		public List<Blog> GetBlogListByWriter(int id)
		{
			return _blogDal.GetListAll(x => x.WriterID == id);
		}


        public void TAdd(Blog entity)
        {
            _blogDal.Insert(entity);
        }


        public void TDelete(Blog entity)
        {
            _blogDal.Delete(entity);
        }


        public void TUpdate(Blog entity)
        {
            _blogDal.Update(entity);
        }

        public object TGetAll()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> BlogLast3Post()
        {
            return _blogDal.GetListAll().TakeLast(3).ToList();
        }
    }
}
