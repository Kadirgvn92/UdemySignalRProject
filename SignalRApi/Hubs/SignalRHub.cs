using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;

namespace SignalRApi.Hubs;

public class SignalRHub : Hub
{
    private readonly ICategoryService _categoryService;
	private readonly IProductService _productService;
	private readonly IOrderService _orderService;
	private readonly IMoneyCaseService _moneyCaseService;
	private readonly IMenuTableService _menuTableService;
	private readonly IBookingService _bookingService;
	private readonly INotificationService _notificationService;


	public SignalRHub(ICategoryService categoryService, IProductService productService, 
		IOrderService orderService, IMoneyCaseService moneyCaseService, 
		IMenuTableService menuTableService, IBookingService bookingService,
		INotificationService notificationService)
	{
		_categoryService = categoryService;
		_productService = productService;
		_orderService = orderService;
		_moneyCaseService = moneyCaseService;
		_menuTableService = menuTableService;
		_bookingService = bookingService;
		_notificationService = notificationService;
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

		var values9 = _productService.TProductNameByMinPrice();
		await Clients.All.SendAsync("ReceiveProductNameByMinPrice", values9);

		var values10 = _productService.TProductAvgPriceByHamburger();
		await Clients.All.SendAsync("ReceiveProductAvgPriceByHamburger", values10);

		var values11 = _orderService.TTotalOrderCount();
		await Clients.All.SendAsync("ReceiveTotalOrderCount", values11);

		var values12 = _orderService.TActiveOrderCount();
		await Clients.All.SendAsync("ReceiveActiveOrderCount", values12);

		var values13 = _orderService.TLastOrderPrice();
		await Clients.All.SendAsync("ReceiveLastOrderPrice", values13.ToString("0.00" + "₺"));

		var values14 = _moneyCaseService.TTotalMoneyCaseAmount();
		await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", values14.ToString("0.00" + "₺"));

		var values16 = _menuTableService.TMenuTableCount();
		await Clients.All.SendAsync("ReceiveMenuTableCount", values16);
	}
	public async Task SendProgress()
	{
        var value = _moneyCaseService.TTotalMoneyCaseAmount();
        await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value.ToString("0.00" + "₺"));

		var value2 = _orderService.TActiveOrderCount();
        await Clients.All.SendAsync("ReceiveActiveOrderCount", value2);

        var value3 = _menuTableService.TMenuTableCount();
        await Clients.All.SendAsync("ReceiveMenuTableCount", value3);
    }
	public async Task GetBookingList()
	{
		var values = _bookingService.TGetListAll();
		await Clients.All.SendAsync("ReceiveBookingList", values);
	}
	public async Task SendNotification()
	{
		var value = _notificationService.TNotificationCountByStatusFalse();
		await Clients.All.SendAsync("ReceiveNotificationCountByFalse", value);
	}


}
