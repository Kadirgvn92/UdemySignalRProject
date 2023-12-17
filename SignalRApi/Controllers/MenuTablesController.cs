using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MenuTableDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MenuTablesController : ControllerBase
{
	private readonly IMenuTableService _menuTableService;

	public MenuTablesController(IMenuTableService menuTableService)
	{
		_menuTableService = menuTableService;
	}
	[HttpGet("MenuTableCount")]
	public IActionResult MenuTableCount()
	{
		return Ok(_menuTableService.TMenuTableCount());
	}
    [HttpGet("ActiveMenuTableCount")]
    public IActionResult ActiveMenuTableCount()
    {
        return Ok(_menuTableService.TActiveMenuTableCount());
    }

    [HttpGet]
	public IActionResult MenuTableList()
	{
		var values = _menuTableService.TGetListAll();
		return Ok(values);
	}
	[HttpPost]
	public IActionResult CreateMenuTable(CreateMenuTableDto createMenuTableDto)
	{
		MenuTable menuTable = new MenuTable()
		{
			 Name = createMenuTableDto.Name,
			 Status = false
		};
		_menuTableService.TAdd(menuTable);
		return Ok("Table is added succesfully");
	}
	[HttpDelete("{id}")]
	public IActionResult DeleteMenuTable(int id)
	{
		var values = _menuTableService.TGetByID(id);
		_menuTableService.TDelete(values);
		return Ok("Table is deleted");
	}
	[HttpPut]
	public IActionResult UpdateMenuTable(UpdateMenuTableDto updateMenuTableDto)
	{
		MenuTable menuTable = new MenuTable()
		{
			MenuTableID = updateMenuTableDto.MenuTableID,
			Name = updateMenuTableDto.Name,
			Status = updateMenuTableDto.Status
		};
		_menuTableService.TUpdate(menuTable);
		return Ok("Table is updated");
	}
	[HttpGet("{id}")]
	public IActionResult GetMenuTable(int id)
	{
		var value = _menuTableService.TGetByID(id);
		return Ok(value);
	}
}
