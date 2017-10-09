using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace Library
{
  public  interface IShoppingStrategy
    {
        IShopping CreateShoppingInstance(UserTypeEnum userType);
    }
}
