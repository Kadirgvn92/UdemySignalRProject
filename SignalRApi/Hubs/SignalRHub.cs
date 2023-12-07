using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;

namespace SignalRApi.Hubs;

public class SignalRHub : Hub
{
    private readonly ICategoryService _categoryService;
	private readonly IProductService _productService;


	public SignalRHub(ICategoryService categoryService, IProductService productService)
	{
		_categoryService = categoryService;
		_productService = productService;
	}

	public async Task SendStatistic()
    {
		var value = _categoryService.TCategoryCount();
        await Clients.All.SendAsync("ReceiveCategoryCount", value);

		var values2 = _productService.TProductCount();
		await Clients.All.SendAsync("ReceiveProductCount", values2);

		var values3 = _categoryService.TActiveCategoryCount();
		await Clients.All.SendAsync("ReceiveActiveCategoryCount", values3);

		var values4 = _categoryService.TPassiveCategoryCount();
		await Clients.All.SendAsync("ReceivePassiveCategoryCount", values4);

		var values5 = _productService.TProductCountByCategoryNameHamburger();
		await Clients.All.SendAsync("ReceiveProductCountByCategoryNameHamburger", values5);

		var values6 = _productService.TProductCountByCategoryNameDrink();
		await Clients.All.SendAsync("ReceiveProductCountByCategoryNameDrink", values6);

		var values7 = _productService.TProductPriceAvg();
		await Clients.All.SendAsync("ReceiveProductPriceAvg", values7.ToString("0.00") + "₺");

		var values8 = _productService.TProductNameByMaxPrice();
		await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", values8);
	}


}
