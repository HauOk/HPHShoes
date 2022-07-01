﻿using OnlineShop.SharedDataModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Entities
{
    public class User
    {
      public int ID { get; set; }
      public string UserName { get; set; }
      public string Password { get; set; }
      public int GroupID { get; set; }
      public string Name { get; set; }
      public string Address { get; set; }
      public string Email { get; set; }
      public int Phone { get; set; }
      public string ProvinceID { get; set; }
      public string DistrictID { get; set; }
      public DateTime CreatedDate { get; set; }
      public string CreatedBy { get; set; }
      public DateTime ModifiedDate { get; set; }
      public string ModifiedBy { get; set; }
      public Status Status { get; set; }
    }
}
