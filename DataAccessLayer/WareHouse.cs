using System.Collections.Generic;
using BusinessLogicLayer;
using BusinessLogicLayer.Product;

namespace DataAccessLayer
{
    public class WareHouse {

        public List<BusinessLogicLayer.Product.Product> RetrieveProducts(Product product, int quantuity) {           
            return new List<Product>();
        }

        public void ReceiveDelivery(Shipment shipment, ProductRepository.ProductRepository productRepo) {
            productRepo.SaveProducts(shipment.FoodProducts, shipment.HealthCosmeticsProducts, shipment.MakeUpProducts);
        }
    }
} 
