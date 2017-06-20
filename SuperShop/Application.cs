using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShop.Partners;
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
            Console.WriteLine("You delivered " + neededFoodProducts + "food products, " + neededHealthCosmetics + "Health Cosmetics, " + neededMakeUp + "make-up products");
        }
        public void DeleteProducts(int productId, int instanceCount)
        {
            ProductRepository.DeleteProduct(productId, instanceCount);
        }

        public void UpdateProduct(int productId, string name, string description)
        {
            Product.Product updatedProduct = ProductRepository.Retrieve(productId);
            updatedProduct.Name = name;
            updatedProduct.Description = description;
        }

        public void FindProducts(int productId)
        {

        }
        

    }
}
