using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.SliderDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping;

public class SliderMapping : Profile
{
	public SliderMapping()
	{
		CreateMap<Slider, ResultSliderDto>().ReverseMap();
		CreateMap<Slider, CreateSliderDto>().ReverseMap();
		CreateMap<Slider, UpdateSliderDto>().ReverseMap();
	}
}
