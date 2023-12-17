using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AboutController : ControllerBase
{
    private readonly IAboutService _aboutService;

    public AboutController(IAboutService aboutService)
    {
        _aboutService = aboutService;
    }

    [HttpGet]
    public IActionResult AboutList()
    {
        var values = _aboutService.TGetListAll();
        return Ok(values);
    }
    [HttpPost]
    public IActionResult CreateAbout(CreateAboutDto createAboutDto)
    {
        About about = new About()
        {
            Title = createAboutDto.Title,
            Description = createAboutDto.Description,
            ImageUrl = createAboutDto.ImageUrl
        };
        _aboutService.TAdd(about);
        return Ok("Section of About is added succesfully");
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteAbout(int id)
    {
        var values = _aboutService.TGetByID(id);
        _aboutService.TDelete(values);
        return Ok("Section of About is deleted");  
    }
    [HttpPut]
    public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
    {
        About about = new About()
        {
            AboutID = updateAboutDto.AboutID,
            Title = updateAboutDto.Title,
            Description = updateAboutDto.Description,
            ImageUrl = updateAboutDto.ImageUrl
        };
        _aboutService.TUpdate(about);
        return Ok("Section of About is updated");
    }
    [HttpGet("{id}")]
    public IActionResult GetAbout(int id)
    {
        var value = _aboutService.TGetByID(id);
        return Ok(value);
    }
    //[HttpGet("UIAbout")]
    //public IActionResult UIAbout()
    //{
    //    var values = _aboutService.TGetListAll();
    //    return Ok(values);
    //}

}
