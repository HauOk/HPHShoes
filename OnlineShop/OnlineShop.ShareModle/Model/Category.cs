using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.ShareModels.Model
{
    public class Category
    {  
        public int ID { set; get; }
        public string Name { set; get; }
        public int? ParentID { set; get; }
        public DateTime CreatedDate { set; get; }
    }
}
