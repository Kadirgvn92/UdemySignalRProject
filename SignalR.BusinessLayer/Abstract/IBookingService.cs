using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract;
public interface IBookingService :IGenericService<Booking>
{
	void BookingStatusApproved(int id);
	void BookingStatusCanceled(int id);
	List<Booking> TGetBookingStatusApproved();
	List<Booking> TGetBookingStatusCanceled();
	List<Booking> TGetBookingStatusReceived();
}
