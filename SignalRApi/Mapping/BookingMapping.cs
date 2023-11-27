﻿using AutoMapper;
using SignalR.DtoLayer.BookindDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping;

public class BookingMapping : Profile
{
    public BookingMapping()
    {
        CreateMap<Booking, ResultBookingDto>().ReverseMap();
        CreateMap<Booking, CreateBookingDto>().ReverseMap();
        CreateMap<Booking, UpdateBookingDto>().ReverseMap();
        CreateMap<Booking, GetBookingDto>().ReverseMap();
    }
}
