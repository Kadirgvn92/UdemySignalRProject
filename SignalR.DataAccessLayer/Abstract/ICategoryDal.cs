using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract;
public interface ICategoryDal : IGenericDal<Category>
{
	public int CategoryCount();
	public int ActiveCategoryCount();
	public int PassiveCategoryCount();
}
