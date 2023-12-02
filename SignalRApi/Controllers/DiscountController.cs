using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.Discount;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DiscountController : ControllerBase
{
    private readonly IDiscountService _discountService;
    private readonly IMapper _mapper;

    public DiscountController(IDiscountService discountService, IMapper mapper)
    {
        _discountService = discountService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult DiscountList()
    {
        var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
        return Ok(value);
    }
    [HttpPost]
    public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
    {
        _discountService.TAdd(new Discount()
        {
            Amount = createDiscountDto.Amount,
            Description = createDiscountDto.Description,
            ImageUrl = createDiscountDto.ImageUrl,
            Title = createDiscountDto.Title
        });
        return Ok("Discount has been added");
    }
    [HttpDelete]
    public IActionResult DeleteDiscount(int id)
    {
        var values = _discountService.TGetByID(id);
        _discountService.TDelete(values);
        return Ok("Discount has been deleted");
    }

    [HttpGet("GetDiscount")]
    public IActionResult GetDiscount(int id)
    {
        var values = _discountService.TGetByID(id);
        return Ok(values);
    }
    [HttpPut]
    public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
    {
        _discountService.TUpdate(new Discount()
        {
            DiscountID = updateDiscountDto.DiscountID,
            Amount = updateDiscountDto.Amount,
            Description = updateDiscountDto.Description,
            ImageUrl = updateDiscountDto.ImageUrl,
            Title = updateDiscountDto.Title
        });
        return Ok("Discount has been updated");
    }
}
