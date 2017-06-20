using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Product
{
    internal interface IProducts
    {
        int ProductID { get; set; }
        float CurrentPrice { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime ExpirationDateTime { get; set; }
        int InstanceCount { get; set; }

        bool Validate();

        bool CheckExpirationDate();

    }
}
