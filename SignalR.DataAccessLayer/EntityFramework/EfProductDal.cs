﻿using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework;
public class EfProductDal : GenericRepository<Product>, IProductDal
{
    public EfProductDal(SignalRContext context) : base(context)
    {
    }

    public List<Product> GetProductsWithCategories()
    {
        var context = new SignalRContext();
        var values = context.Products.Include(x => x.Category).ToList();
        return values;
    }

	public int ProductCount()
	{
		using var context = new SignalRContext();   
        return context.Products.Count();
	}

	public int ProductCountByCategoryNameDrink()
	{
		using var context = new SignalRContext();
		return context.Products.Where(x => x.CategoryID == (context.Categories.
			Where(y => y.CategoryName == "İçecek").Select(z => z.CategoryID).FirstOrDefault())).Count();
	}

	public int ProductCountByCategoryNameHamburger()
	{
		using var context = new SignalRContext();
		return context.Products.Where(x => x.CategoryID == (context.Categories.
			Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Count();
	}

	public string ProductNameByMaxPrice()
	{
		using var context = new SignalRContext();
		return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
	}

	public string ProductNameByMinPrice()
	{
		using var context = new SignalRContext();
		return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
	}

	public decimal ProductPriceAvg()
	{
		using var context = new SignalRContext();
		return context.Products.Average(x => x.Price);
	}

	public decimal ProductAvgPriceByHamburger()
	{
		using var context = new SignalRContext();
		return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Hamburger").
		Select(z => z.CategoryID).FirstOrDefault())).Average(j => j.Price);
	}
}
