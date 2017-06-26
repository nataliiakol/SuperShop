using System.Collections.Generic;
using BusinessLogicLayer;
using BusinessLogicLayer.Product;

namespace DataAccessLayer
{
    public class WareHouse
    {

        public void ReceiveDeliveryFood(Shipment shipment, ProductRepository.ProductRepository<FoodProducts> productRepo) {
            productRepo.AddProducts(shipment.FoodProducts);
        }

        public void ReceiveDeliveryHealth(Shipment shipment, ProductRepository.ProductRepository<HealthCosmetics> productRepo)
        {
            productRepo.AddProducts(shipment.HealthCosmeticsProducts);
        }

        public void ReceiveDeliveryMakeUp(Shipment shipment, ProductRepository.ProductRepository<MakeUp> productRepo)
        {
            productRepo.AddProducts(shipment.MakeUpProducts);
        }
    }
} 
