using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MessageDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MessageController : ControllerBase
{
	private readonly IMessageService _messageService;

	public MessageController(IMessageService messageService)
	{
		_messageService = messageService;
	}

	[HttpGet]
	public IActionResult MessageList()
	{
		var values = _messageService.TGetListAll();
		return Ok(values);
	}
	[HttpPost]
	public IActionResult CreateMessage(CreateMessageDto createMessageDto)
	{
		Message message = new Message()
		{
			NameSurname = createMessageDto.NameSurname,
			Mail = createMessageDto.Mail,	
			Phone = createMessageDto.Phone,
			MessageContent = createMessageDto.MessageContent,
			MessageSendDate = createMessageDto.MessageSendDate,
			Subject = createMessageDto.Subject,
			Status = createMessageDto.Status
		};
		_messageService.TAdd(message);
		return Ok("Messasge is added succesfully");
	}
	[HttpDelete("{id}")]
	public IActionResult DeleteMessage(int id)
	{
		var values = _messageService.TGetByID(id);
		_messageService.TDelete(values);
		return Ok("Message is deleted");
	}
	[HttpPut]
	public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
	{
		Message message = new Message()
		{
			MessageID = updateMessageDto.MessageID,	
			NameSurname = updateMessageDto.NameSurname,
			Mail = updateMessageDto.Mail,
			Phone = updateMessageDto.Phone,
			MessageContent = updateMessageDto.MessageContent,
			MessageSendDate = updateMessageDto.MessageSendDate,
			Subject = updateMessageDto.Subject,
			Status = updateMessageDto.Status
		};
		_messageService.TUpdate(message);
		return Ok("Section of Message is updated");
	}
	[HttpGet("{id}")]
	public IActionResult GetMessage(int id)
	{
		var value = _messageService.TGetByID(id);
		return Ok(value);
	}
}
