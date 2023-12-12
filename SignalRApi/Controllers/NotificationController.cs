using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.NotificationDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class NotificationController : ControllerBase
{
	private readonly INotificationService _notificationService;

	public NotificationController(INotificationService notificationService)
	{
		_notificationService = notificationService;
	}
	[HttpGet]
	public IActionResult NotificationList()
	{
		return Ok(_notificationService.TGetListAll());
	}
	[HttpGet("NotificationCountByStatusFalse")]
	public IActionResult NotificationCountByStatusFalse()
	{
		return Ok(_notificationService.TNotificationCountByStatusFalse());
	}
	[HttpGet("GetAllNotificationByFalse")]
	public IActionResult GetAllNotificationByFalse()
	{
		return Ok(_notificationService.TGetAllNotificationByFalse());
	}
	[HttpPost]
	public IActionResult CreateNotification(CreateNotificationDto createNotificationDto)
	{
		Notification notification = new Notification()
		{
			Description = createNotificationDto.Description,
			Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
			Icon = createNotificationDto.Icon,
			Status = false,
			Type = createNotificationDto.Type
		};
		_notificationService.TAdd(notification);
		return Ok("Ekleme işlemi başarıyla yapıldı");	
	}

	[HttpDelete("{id}")]
	public IActionResult DeleteNotification(int id)
	{
		var value = _notificationService.TGetByID(id);

		_notificationService.TDelete(value);
		return Ok("Bildirim Silindi");
	}
	[HttpGet("{id}")]
	public IActionResult GetNotification(int id)
	{
		var value = _notificationService.TGetByID(id);
		return Ok(value);
	}
	[HttpPut]
	public IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
	{
		Notification notification = new Notification()
		{
			NotificationID = updateNotificationDto.NotificationID,
			Description = updateNotificationDto.Description,
			Date = updateNotificationDto.Date,
			Icon = updateNotificationDto.Icon,
			Status = updateNotificationDto.Status,
			Type = updateNotificationDto.Type
		};
		_notificationService.TUpdate(notification);
		return Ok("Bildirim Güncellendi.");
	}


}
