using OnlineShop.SharedDataModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Entities
{
    public class Menu
    {
      public int ID { get; set; }
      public string Text { get; set; }
      public string Link { get; set; }
      public int DisplayOrder { get; set; }
      public string Target { get; set; }
      public Status Status { get; set; }
      public int TypeID { get; set; }
    }
}
