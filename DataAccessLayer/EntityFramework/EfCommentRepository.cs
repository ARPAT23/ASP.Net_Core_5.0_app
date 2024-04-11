using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Command>,ICommentDal 
    {
        public List<Command> GetListWithBlog()
        {
            using (var c = new Context())
            {
                return c.Coments.Include(x => x.Blog).Where(y => y.IsDelete == false).ToList();
            }
        }
    }
}