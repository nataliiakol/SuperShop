using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShop.Partners;
using SuperShop.Product;
using SuperShop.Product_repository;

namespace SuperShop
{
    public class WareHouse {

        public List<Product.Product> RetrieveProducts(Product.Product product, int quantuity) {           
            return new List<Product.Product>();
        }

        public void ReceiveDelivery(Shipment shipment) {
            ProductRepository.SaveProducts(shipment.Products);
        }
    }
}
