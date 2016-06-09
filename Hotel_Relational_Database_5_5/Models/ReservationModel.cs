using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel_Relational_Database_5_5.Models
{
    public class ReservationModel
    {
        [Key]
        public int ReservationID { get; set; }

        //foreign key for guest id
        public int GuestID { get; set; }
        public GuestModel Guest { get; set; }

        //foreign key for room id
        [Display(Name = "Room Number")]
        public int RoomID { get; set; }
        public RoomModel Room { get; set; }
    }
}