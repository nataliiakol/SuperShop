using System.Collections.Generic;
using SuperShop.Product_repository;

namespace SuperShop
{
    public class WareHouse {

        public List<Product.Product> RetrieveProducts(Product.Product product, int quantuity) {           
            return new List<Product.Product>();
        }

        public void ReceiveDelivery(Shipment shipment, ProductRepository productRepo) {
            productRepo.SaveProducts(shipment.FoodProducts, shipment.HealthCosmeticsProducts, shipment.MakeUpProducts);
        }
    }
} 
