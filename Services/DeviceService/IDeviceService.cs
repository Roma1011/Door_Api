using WebAPI.Models.DeviceModel;

namespace WebAPI.Services.DeviceService;

public interface IDeviceService
{
	Task<List<string?>> AddOrderHistory(OrderHistory order);
	Task<List<DeviceModel>> GetAllDevices();
    Task<List<OrderModel>> GetAllOrders();
    Task<List<OrderHistory>> GetOrderHistory();
    Task<List<ListenerModel>> GetListenerInfo();
    Task<string> GetStatus(long imei);
}