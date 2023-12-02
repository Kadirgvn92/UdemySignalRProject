using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TestimonialController : ControllerBase
{
    private readonly ITestimonialService _testimonialService;
    private readonly IMapper _mapper;

    public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
    {
        _testimonialService = testimonialService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult TestimonialList()
    {
        var value = _mapper.Map<List<ResultTestimonailDto>>(_testimonialService.TGetListAll());
        return Ok(value);
    }
    [HttpPost]
    public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
    {
        _testimonialService.TAdd(new Testimonial()
        {
             Name = createTestimonialDto.Name,
             Comment = createTestimonialDto.Comment,
             ImageUrl = createTestimonialDto.ImageUrl,
             Status = createTestimonialDto.Status,
             Title = createTestimonialDto.Title
        });
        return Ok("Testimonial has been added");
    }
    [HttpDelete]
    public IActionResult DeleteTestimonial(int id)
    {
        var values = _testimonialService.TGetByID(id);
        _testimonialService.TDelete(values);
        return Ok("Testimonial has been deleted");
    }

    [HttpGet("GetTestimonial")]
    public IActionResult GetTestimonial(int id)
    {
        var values = _testimonialService.TGetByID(id);
        return Ok(values);
    }
    [HttpPut]
    public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
    {
        _testimonialService.TUpdate(new Testimonial()
        {
            Name = updateTestimonialDto.Name,
            Comment = updateTestimonialDto.Comment,
            ImageUrl = updateTestimonialDto.ImageUrl,
            Status = updateTestimonialDto.Status,
            Title = updateTestimonialDto.Title
        });
        return Ok("Testimonial has been updated");
    }
}
