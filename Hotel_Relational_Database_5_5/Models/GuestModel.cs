using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel_Relational_Database_5_5.Models
{
    public class GuestModel
    {
        [Key]
        [Display(Name = "Guest ID #")]
        public int GuestID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Total Guests")]
        public int TotalGuests { get; set; }
    }
}