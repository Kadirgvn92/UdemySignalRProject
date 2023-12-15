using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalR.EntityLayer.Entities;
using SignalRWebUI.Dtos.IdentityDtos;

namespace SignalRWebUI.Controllers;
public class SettingController : Controller
{
	private readonly UserManager<AppUser> _userManager;

	public SettingController(UserManager<AppUser> userManager)
	{
		_userManager = userManager;
	}
	[HttpGet]
	public async Task<IActionResult> Index()
	{
		var values = await _userManager.FindByNameAsync(User.Identity.Name);
		UserEditDto userEditDto = new UserEditDto();
		userEditDto.Name = values.Name;
		userEditDto.Surname = values.Surname;
		userEditDto.Username = values.UserName;
		userEditDto.Mail = values.Email;
		return View(userEditDto);
	}
}
