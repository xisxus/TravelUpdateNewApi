using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class TourVoucher
    {
        public int TourVoucherID { get; set; }
        public string TourVoucherCode { get; set; } 
        public string? VoucherUrl { get; set; }


        //public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
    }
}
