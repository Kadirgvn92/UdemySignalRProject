﻿namespace SignalR.EntityLayer.Entities;

public class Booking
{
    public int BookingID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public int PersonelCount { get; set; }
    public DateTime Date { get; set; }
}
