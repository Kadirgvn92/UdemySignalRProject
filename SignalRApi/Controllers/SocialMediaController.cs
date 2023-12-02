using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SocialMediaController : ControllerBase
{
    private readonly ISocialMediaService _socialMediaService;
    private readonly IMapper _mapper;

    public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
    {
        _socialMediaService = socialMediaService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult SocialMediaList()
    {
        var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetListAll());
        return Ok(value);
    }
    [HttpPost]
    public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
    {
        _socialMediaService.TAdd(new SocialMedia()
        {
            Title = createSocialMediaDto.Title,
            Icon = createSocialMediaDto.Icon,
            Url = createSocialMediaDto.Url
        });
        return Ok("SocialMedia has been added");
    }
    [HttpDelete]
    public IActionResult DeleteSocialMedia(int id)
    {
        var values = _socialMediaService.TGetByID(id);
        _socialMediaService.TDelete(values);
        return Ok("SocialMedia has been deleted");
    }

    [HttpGet("GetSocialMedia")]
    public IActionResult GetSocialMedia(int id)
    {
        var values = _socialMediaService.TGetByID(id);
        return Ok(values);
    }
    [HttpPut]
    public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
    {
        _socialMediaService.TUpdate(new SocialMedia()
        {
            SocialMediaID = updateSocialMediaDto.SocialMediaID,
            Title = updateSocialMediaDto.Title,
            Icon = updateSocialMediaDto.Icon,
            Url = updateSocialMediaDto.Url
        });
        return Ok("SocialMedia has been updated");
    }
}
