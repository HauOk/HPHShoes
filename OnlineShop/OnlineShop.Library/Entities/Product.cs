using OnlineShop.SharedDataModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.SharedDataModel.Entities
{
    public class Product
    {
      public int ID { get; set; }
      public string Name { get; set; }
      public int Code { get; set; }
      public int MetaTitle { get; set; }
      public string Image { get; set; }
      public decimal Price { get; set; }
      public decimal PromotionPrice { get; set; }
      public int Quantity { get; set; }
      public int CategoryID { get; set; }
      public Status Status { get; set; }
      public int ViewCount { get; set; }
    }
}
