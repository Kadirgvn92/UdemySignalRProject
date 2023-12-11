using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.BasketDto;
using SignalR.EntityLayer.Entities;
using SignalRApi.Models;
using System.Net.Http;
using System.Text;

namespace SignalRApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BasketController : ControllerBase
{
    private readonly IBasketService _basketService;

    public BasketController(IBasketService basketService)
    {
        _basketService = basketService;
    }

    [HttpGet]
    public IActionResult GetBasketByMenuTableID(int id)
    {
        var values = _basketService.TGetBasketByMenuTableNumber(id);
        return Ok(values);
    }
    [HttpGet("BasketListByMenuTableWithProductName")]
    public IActionResult BasketListByMenuTableWithProductName(int id)
    {
        using var context = new SignalRContext();
        var values = context.Baskets.Include(x => x.Product).Where(y => y.MenuTableID == id).Select(z => new
        ResultBasketListWithProducts
        {
            BasketID = z.BasketID,
            MenuTableID = z.MenuTableID,
            Count = z.Count,
            Price = z.Price,
            ProductID = z.ProductID,
            TotalPrice = z.TotalPrice,
            ProductName = z.Product.ProductName
        }).ToList();
        return Ok(values);
    }
    [HttpPost]
    public IActionResult CreateBasket(CreateBasketDto createBasketDto)
    {
        using var context = new SignalRContext();
        _basketService.TAdd(new Basket()
        {
            ProductID = createBasketDto.ProductID,
            Count = 1,
            MenuTableID = 4,
            Price = context.Products.Where(x => x.ProductID == createBasketDto.ProductID).Select(y => y.Price).FirstOrDefault(),
            TotalPrice = 0 
        });
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBasket(int id)
    {
       var values = _basketService.TGetByID(id);
        _basketService.TDelete(values);
        return Ok("Sepetteki Seçilen Ürün silindi");

    }

}
