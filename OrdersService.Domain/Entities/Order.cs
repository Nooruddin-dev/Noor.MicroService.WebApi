using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Domain.Entities
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerID { get; set; }
        public string? OrderNumber { get; set; }
        public DateTime? OrderDateUTC { get; set; }

        public int LatestStatusID { get; set; }
        public int ShippingAddressID { get; set; }
   

    }
}
