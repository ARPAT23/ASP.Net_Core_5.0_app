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
	public class CommentManager : ICommentService
	{
		ICommentDal _commentdal;

		public CommentManager(ICommentDal commentdal)
		{
			_commentdal = commentdal;
		}

		public void CommandAdd(Command command)
		{
			_commentdal.Insert(command);
		}

        public List<Command> TGetAll()
        {
            throw new NotImplementedException();
        }
        public List<Command> GetCommentWithBlog()
        {
           return _commentdal.GetListWithBlog();
        }
        public void CommentDelete(Command command)
        {
            throw new NotImplementedException();
        }
        
        public List<Command> GetList(int id)
		{
			return _commentdal.GetListAll(x => x.BlogID == id);
		}
        public Command CommandGetById(int id)
        {
            return _commentdal.GetByID(id);
        }

        public void TUpdate(Command command)
        {
            _commentdal.Update(command);
        }
    }
}
