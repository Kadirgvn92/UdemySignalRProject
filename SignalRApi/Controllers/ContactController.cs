using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ContactController : ControllerBase
{
    private readonly IContactService _contactService;
    private readonly IMapper _mapper;
    public ContactController(IContactService contactService, IMapper mapper)
    {
        _contactService = contactService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult ContactList()
    {
        var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
        return Ok(value);
    }
    [HttpPost]
    public IActionResult CreateContact(CreateContactDto createContactDto)
    {
        _contactService.TAdd(new Contact()
        {
            FooterDescription = createContactDto.FooterDescription,
            Location = createContactDto.Location,
            Mail = createContactDto.Mail,
            Phone = createContactDto.Phone
        });
        return Ok("Contact has been added");
    }
    [HttpDelete]
    public IActionResult DeleteContact(int id)
    {
        var values = _contactService.TGetByID(id);
        _contactService.TDelete(values);
        return Ok("Contact has been deleted");
    }

    [HttpGet("GetContact")]
    public IActionResult GetContact(int id)
    {
        var values = _contactService.TGetByID(id);
        return Ok(values);
    }
    [HttpPut]
    public IActionResult UpdateContact(UpdateContactDto updateContactDto)
    {
        _contactService.TUpdate(new Contact()
        {
            ContactID = updateContactDto.ContactID, 
            FooterDescription = updateContactDto.FooterDescription,
            Location = updateContactDto.Location,
            Mail = updateContactDto.Mail,
            Phone = updateContactDto.Phone
        });
        return Ok("Contact has been updated");
    }
}
