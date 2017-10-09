using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ShoppingStrategy : IShoppingStrategy
    {
        public IShopping CreateShoppingInstance(UserTypeEnum userType)
        {
            IShopping shopping = null;
            switch (userType)
            {
                case UserTypeEnum.Employee:
                    shopping = new Employee();
                    break;
                case UserTypeEnum.Affiliate:
                    shopping = new Affiliate();
                    break;
                case UserTypeEnum.Customer:
                    shopping = new Customer();
                    break;
                default:
                    shopping = new Other();
                    break;
            }

            return shopping;
        }
    }
}
