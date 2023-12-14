using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SliderDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SliderController : ControllerBase
{
    private readonly ISliderService _sliderService;
    private readonly IMapper _mapper;

    public SliderController(ISliderService sliderService, IMapper mapper)
    {
        _sliderService = sliderService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult SliderList()
    {
        var value = _mapper.Map<List<ResultSliderDto>>(_sliderService.TGetListAll());
        return Ok(value);
    }
    [HttpPost]
    public IActionResult CreateSlider(CreateSliderDto createSliderDto)
    {
        _sliderService.TAdd(new Slider()
        {
            Description1 = createSliderDto.Description1,   
            Description2 = createSliderDto.Description2,
            Description3 = createSliderDto.Description3,
            Title1 = createSliderDto.Title1,
            Title2 = createSliderDto.Title2,
            Title3 = createSliderDto.Title3
        });
        return Ok("Slider has been added");
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteSlider(int id)
    {
        var values = _sliderService.TGetByID(id);
        _sliderService.TDelete(values);
        return Ok("Slider has been deleted");
    }

    [HttpGet("{id}")]
    public IActionResult GetSlider(int id)
    {
        var values = _sliderService.TGetByID(id);
        return Ok(values);
    }
    [HttpPut]
    public IActionResult UpdateSlider(UpdateSliderDto updateSliderDto)
    {
        _sliderService.TUpdate(new Slider()
        {
            SliderID = updateSliderDto.SliderID,
            Description1 = updateSliderDto.Description1,
            Description2 = updateSliderDto.Description2,
            Description3 = updateSliderDto.Description3,
            Title1 = updateSliderDto.Title1,
            Title2 = updateSliderDto.Title2,
            Title3 = updateSliderDto.Title3
        });
        return Ok("Slider has been updated");
    }
}
