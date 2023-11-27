﻿using AutoMapper;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping;

public class TestimonialMapping : Profile
{
    public TestimonialMapping()
    {
        CreateMap<Testimonial, ResultTestimonailDto>().ReverseMap();
        CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
        CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
        CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();

    }
}
