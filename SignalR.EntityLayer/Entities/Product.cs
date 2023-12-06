﻿namespace SignalR.EntityLayer.Entities;
public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public bool ProductStatus { get; set; }
    public int CategoryID { get; set; } //Bire çok ilişki için ekliyoruz 
    public Category Category { get; set; } //Bire çok ilişki için ekliyoruz 
    public List<OrderDetail> OrderDetails { get; set; } 
}
