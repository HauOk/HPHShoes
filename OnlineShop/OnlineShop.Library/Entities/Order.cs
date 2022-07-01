using OnlineShop.SharedDataModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.SharedDataModel.Entities
{
    public class Order
    {
      public int ID     { get; set; }
      public DateTime CreateDate     { get; set; }
      public Guid CustomerID { get; set; }
      public string ShipName   { get; set; }
      public string ShipMobile { get; set; }
      public string ShipAddress { get; set; }
      public string ShipEmail { get; set; }     
      public OrderStatus Status { get; set; }
      public List<OrderDetail> OrderDetails { get; set; }
    }
}
