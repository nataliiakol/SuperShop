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
    public class Application {

        private WareHouse wareHouse;
        private DeliveryAgency delivery;

        public Application() {
            wareHouse = new WareHouse();
            delivery = new DeliveryAgency();
    }

    public void DeliverGoods(int neededFoodProducts, int neededHealthCosmetics, int neededMakeUp) {
            Shipment shipment = delivery.Ship(neededFoodProducts, neededHealthCosmetics, neededMakeUp);
            wareHouse.ReceiveDelivery(shipment);
        }
        public void DeleteProducts(int productId, int instanceCount)
        {
            ProductRepository.DeleteProduct(productId, instanceCount);
        }

        public void UpdateProduct(int productId, string name, string description)
        { 
            ProductRepository.UpdateProduct(productId, new FoodProducts(1));
        }

        public void FindProducts(int productId) {
            ProductRepository.Retrieve(productId);
        }
        

    }
}
