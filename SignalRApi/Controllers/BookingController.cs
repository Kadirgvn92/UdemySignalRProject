using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.BookingDto;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;
using System.Linq;

namespace SignalRApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookingController : ControllerBase
{
    private readonly IBookingService _bookingService;

    public BookingController(IBookingService bookingService)
    {
        _bookingService = bookingService;
    }
    [HttpGet]
    public IActionResult BookingList()
    {
        var values = _bookingService.TGetListAll();
        return Ok(values);
    }
    [HttpPost]
    public IActionResult CreateBooking(CreateBookingDto createBookingDto)
    {
        Booking booking = new Booking()
        {
            Description = "Rezervasyon Alındı",
            Mail = createBookingDto.Mail,
            Name = createBookingDto.Name,
            Date = createBookingDto.Date,
            PersonelCount = createBookingDto.PersonelCount,
            Phone = createBookingDto.Phone
            
        };
        _bookingService.TAdd(booking);
        return Ok("Your reservation is done");
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteBooking(int id)
    {
        var values = _bookingService.TGetByID(id);
        _bookingService.TDelete(values);
        return Ok("Your reservation is canceled");
    }

    [HttpPut]
    public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
    {
        Booking booking = new Booking()
        {
            Description = updateBookingDto.Description,
            BookingID = updateBookingDto.BookingID,
            Mail = updateBookingDto.Mail,
            Name = updateBookingDto.Name,
            Date = updateBookingDto.Date,
            PersonelCount = updateBookingDto.PersonelCount,
            Phone = updateBookingDto.Phone
        };
        _bookingService.TUpdate(booking);
        return Ok("Your reservaiton is updated");
    }

    [HttpGet("{id}")]
    public IActionResult GetBooking(int id)
    {
        var values = _bookingService.TGetByID(id);
        return Ok(values);
    }
    [HttpGet("BookingStatusApproved/{id}")]
    public IActionResult BookingStatusApproved(int id)
    {
        _bookingService.BookingStatusApproved(id);
        return Ok("Rezervasyon Açıklaması Değiştirildi");
    }
	[HttpGet("BookingStatusCanceled/{id}")]
	public IActionResult BookingStatusCanceled(int id)
	{
		_bookingService.BookingStatusCanceled(id);
		return Ok("Rezervasyon Açıklaması Değiştirildi");
	}
	[HttpGet("GetBookingStatusApproved")]
	public IActionResult GetBookingStatusApproved()
	{
		var context = new SignalRContext();
        var values = context.Bookings.Where(x => x.Description == "Rezervasyon Onaylandı").ToList();
		return Ok(values.ToList());
	}
	[HttpGet("GetBookingStatusCanceled")]
	public IActionResult GetBookingStatusCanceled()
	{
		var context = new SignalRContext();
		var values = context.Bookings.Where(x => x.Description == "Rezervasyon İptal Edildi").ToList();
		return Ok(values.ToList());
	}
	[HttpGet("GetBookingStatusReceived")]
	public IActionResult GetBookingStatusReceived()
	{
		var context = new SignalRContext();
		var values = context.Bookings.Where(x => x.Description == "Rezervasyon Alındı").ToList();
		return Ok(values.ToList());
	}
    [HttpGet("BookingStatusApprovedCount")]
    public IActionResult BookingStatusApprovedCount()
    {
        return Ok(_bookingService.TBookingStatusApprovedCount());
    }
}
