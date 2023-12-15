﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWebUI.Dtos.BookingDtos;
public class ResultBookingStatusApproved
{
	public int BookingID { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public string Phone { get; set; }
	public string Mail { get; set; }
	public int PersonelCount { get; set; }
	public DateTime Date { get; set; } // dikkat değişti datetime eskisi
}
