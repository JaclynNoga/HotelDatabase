using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotel_Relational_Database_5_5.Models
{
    public class Hotel_Relational_Database_5_5Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Hotel_Relational_Database_5_5Context() : base("name=Hotel_Relational_Database_5_5Context")
        {
        }

        public System.Data.Entity.DbSet<Hotel_Relational_Database_5_5.Models.GuestModel> ReservationModels { get; set; }

        public System.Data.Entity.DbSet<Hotel_Relational_Database_5_5.Models.RoomModel> RoomModels { get; set; }

        public System.Data.Entity.DbSet<Hotel_Relational_Database_5_5.Models.ReservationModel> ReservationModels1 { get; set; }
    }
}
