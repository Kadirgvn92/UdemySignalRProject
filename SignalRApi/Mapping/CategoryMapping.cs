﻿using AutoMapper;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping;

public class CategoryMapping : Profile
{
    public CategoryMapping ()
    {
        CreateMap<Category, ResultCategoryDto>().ReverseMap();
        CreateMap<Category, CreateCategoryDto>().ReverseMap();
        CreateMap<Category, UpdateCategoryDto> ().ReverseMap(); 
        CreateMap<Category, GetCategoryDto> ().ReverseMap();
    }
}
