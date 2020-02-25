using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reservation.Models
{
    public class Room
    {
        
        public int ID { get; set; }
        public string name { get; set; }
        public int beds { get; set; }
        public int floor { get; set; }
        
    }
}