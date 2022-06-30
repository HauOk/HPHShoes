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
      public int Name { get; set; }
      public int Code { get; set; }
      public int MetaTitle { get; set; }
      public int Image { get; set; }
      public int Price { get; set; }
      public int PromotionPrice { get; set; }
      public int Quantity { get; set; }
      public int CategoryID { get; set; }
      public int Status { get; set; }
      public int ViewCount { get; set; }
    }
}
