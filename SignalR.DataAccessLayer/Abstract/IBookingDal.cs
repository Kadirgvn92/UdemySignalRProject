﻿using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract;
public interface IBookingDal : IGenericDal<Booking>
{
	void BookingStatusApproved(int id);
	int BookingStatusApprovedCount();
	void BookingStatusCanceled(int id);
	List<Booking> GetBookingStatusApproved();
	List<Booking> GetBookingStatusCanceled();
	List<Booking> GetBookingStatusReceived();
}
