using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.BookindDto;
public class ResultBookingDto
{
    public int BookingID { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Mail { get; set; }
    public int PersonelCount { get; set; }
    public DateTime Date { get; set; }
}
