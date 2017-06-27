using System.Collections.Generic;
using BusinessLogicLayer;
using BusinessLogicLayer.Product;
using DataAccessLayer.Repositories;

namespace DataAccessLayer
{
    public class WareHouse
    {

        public void ReceiveDeliveryFood(Shipment shipment, ProductRepository<FoodProducts> productRepo) {
            productRepo.AddProducts(shipment.FoodProducts);
        }

        public void ReceiveDeliveryHealth(Shipment shipment, ProductRepository<HealthCosmetics> productRepo)
        {
            productRepo.AddProducts(shipment.HealthCosmeticsProducts);
        }

        public void ReceiveDeliveryMakeUp(Shipment shipment, ProductRepository<MakeUp> productRepo)
        {
            productRepo.AddProducts(shipment.MakeUpProducts);
        }

    }

} 
