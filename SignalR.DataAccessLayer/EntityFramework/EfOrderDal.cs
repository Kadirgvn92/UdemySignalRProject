﻿using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework;
public class EfOrderDal : GenericRepository<Order>, IOrderDal
{
	public EfOrderDal(SignalRContext context) : base(context)
	{

	}

	public int ActiveOrderCount()
	{
		using var context = new SignalRContext();
		return context.Orders.Where(x => x.Description == "Hesap aktif").Count();
	}

	public decimal LastOrderPrice()
	{
		using var context = new SignalRContext();
		return context.Orders.OrderByDescending(o => o.OrderID).Take(1).Select(y => y.TotalPrice).FirstOrDefault();


		
	}

	public int TotalOrderCount()
	{
		using var context = new SignalRContext();
		return context.Orders.Count();
	}



}
