using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
	private readonly IOrderService _orderService;

	public OrdersController (IOrderService orderService)
	{
		_orderService = orderService;
	}

	[HttpGet]
	public IActionResult TotalOrderCount()
	{
		return Ok(_orderService.TTotalOrderCount());
	}

	[HttpGet("TotalOrderCount")]
	public IActionResult ActiveOrderCount()
	{
		return Ok(_orderService.TActiveOrderCount());
	}


	[HttpGet("LastOrderPrice")]
	public IActionResult LastOrderPrice()
	{
		return Ok(_orderService.TLastOrderPrice());
	}

}
