using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstract;
public interface IBookingService :IGenericService<Booking>
{
	void BookingStatusApproved(int id);
	void BookingStatusCanceled(int id);
	List<Booking> TGetBookingStatusApproved();
	List<Booking> TGetBookingStatusCanceled();
	List<Booking> TGetBookingStatusReceived();
	int TBookingStatusApprovedCount();
}
