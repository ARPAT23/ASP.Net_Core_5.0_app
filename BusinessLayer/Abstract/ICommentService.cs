using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
		void CommandAdd(Command command);
		//void CategoryDelete(Category category);
		//void CategoryUpdate(Category category);

		List<Command> GetList(int id);
		//Category GetById(int id);

	}
}
