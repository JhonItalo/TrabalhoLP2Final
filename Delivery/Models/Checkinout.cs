using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Models
{
    public class Checkinout
    {
        public int ID { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Cheout { get; set; }
       

        public Checkinout() { }

        public Checkinout(int iD, DateTime checkin, DateTime cheout)
        {
            ID = iD;
            Checkin = checkin;
            Cheout = cheout;
            
        }
    }
}
