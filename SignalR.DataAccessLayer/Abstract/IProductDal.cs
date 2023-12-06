using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract;
public interface IProductDal : IGenericDal<Product>
{
    List<Product> GetProductsWithCategories();
    public int ProductCount();
    public int ProductCountByCategoryNameHamburger();
    public int ProductCountByCategoryNameDrink();
    public decimal ProductPriceAvg();
    public string ProductNameByMaxPrice();
    public string ProductNameByMinPrice();

}
