using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel_Relational_Database_5_5.Models
{
    public class RoomModel
    {
        [Key]
        public int RoomID { get; set; }
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }
        [Display(Name = "Price per Night")]
        public decimal RoomPrice { get; set; }
        [Display(Name = "Max Occupancy")]
        public int MaxOccupancy { get; set; }
    }
}