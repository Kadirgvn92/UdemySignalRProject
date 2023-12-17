using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete;
public class BookingManager : IBookingService
{
    private readonly IBookingDal _bookingDal;

    public BookingManager(IBookingDal bookingDal)
    {
        _bookingDal = bookingDal;
    }

	public void BookingStatusApproved(int id)
	{
		_bookingDal.BookingStatusApproved(id);
	}

	public void BookingStatusCanceled(int id)
	{
		_bookingDal.BookingStatusCanceled(id);
	}

	public List<Booking> TGetBookingStatusCanceled()
	{
		return _bookingDal.GetBookingStatusCanceled();
	}

	public List<Booking> TGetBookingStatusReceived()
	{
		return _bookingDal.GetBookingStatusReceived();
	}

	public void TAdd(Booking entity)
    {
        _bookingDal.Add(entity);
    }

    public void TDelete(Booking entity)
    {
       _bookingDal.Delete(entity);
    }

	public List<Booking> TGetBookingStatusApproved()
	{
		return _bookingDal.GetBookingStatusApproved();
	}

	public Booking TGetByID(int id)
    {
        return _bookingDal.GetByID(id);
    }

    public List<Booking> TGetListAll()
    {
        return _bookingDal.GetListAll();
    }

    public void TUpdate(Booking entity)
    {
        _bookingDal.Update(entity);
    }

    public int TBookingStatusApprovedCount()
    {
        return _bookingDal.BookingStatusApprovedCount();
    }
}
