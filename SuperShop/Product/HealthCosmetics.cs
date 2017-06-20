using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShop.Product;

namespace SuperShop
{
    public class HealthCosmetics : Cosmetics
    {
        public HealthCosmetics(int productID) {
            ProductID = productID;
        }

        public override bool Validate() {
            return true;
        }
    }
}
