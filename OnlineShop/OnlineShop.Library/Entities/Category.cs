using OnlineShop.SharedDataModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.SharedDataModel.Entities
{
    public class Category
    {
      public int ID { get; set; }
      public string Name { get; set; }
      public string MetaTitle { get; set; }
      public int ParentID { get; set; }
      public int DisplayOrder { get; set; }
      public string SeoTitle { get; set; }
      public DateTime CreatedDate { get; set; }
      public string CreatedBy { get; set; }
      public DateTime ModifiedDate { get; set; }
      public string ModifiedBy { get; set; }
      public string MetaKeywords { get; set; }
      public string MetaDescriptions { get; set; }
      public Status Status { get; set; }
      public bool ShowOnHome { get; set; }
    }
}
