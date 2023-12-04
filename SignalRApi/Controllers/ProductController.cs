using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;

    public ProductController(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult ProductList()
    {
        var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
        return Ok(value);
    }


    [HttpGet("ProductListWithCategory")]
    public IActionResult ProductListWithCategory()
    {
        var context = new SignalRContext();
        var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWitCategory
        {
            Description = y.Description,
            ImageUrl = y.ImageUrl,
            Price = y.Price,
            ProductID = y.ProductID,
            ProductName = y.ProductName,
            ProductStatus = y.ProductStatus,
            CategoryName = y.Category.CategoryName,

        });
        return Ok(values.ToList());
    }

    [HttpPost]
    public IActionResult CreateProduct(CreateProductDto createProductDto)
    {
        _productService.TAdd(new Product()
        {
           Description = createProductDto.Description,
           ImageUrl = createProductDto.ImageUrl,
           Price = createProductDto.Price,
           ProductName = createProductDto.ProductName,
           ProductStatus = createProductDto.ProductStatus,
           CategoryID = createProductDto.CategoryID
        });
        return Ok("Product has been added");
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var values = _productService.TGetByID(id);
        _productService.TDelete(values);
        return Ok("Product has been deleted");
    }

    [HttpGet("{id}")]
    public IActionResult GetProduct(int id)
    {
        var values = _productService.TGetByID(id);
        return Ok(values);
    }
    [HttpPut]
    public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
    {
        _productService.TUpdate(new Product()
        {
            Description = updateProductDto.Description,
            ImageUrl = updateProductDto.ImageUrl,
            Price = updateProductDto.Price,
            ProductName = updateProductDto.ProductName,
            ProductStatus = updateProductDto.ProductStatus,
            ProductID = updateProductDto.ProductID,
            CategoryID = updateProductDto.CategoryID    
        });
        return Ok("Product has been updated");
    }
}
