using System.Collections.Generic;
using BusinessLogicLayer;
using BusinessLogicLayer.Partners;
using BusinessLogicLayer.Product;
using BusinessLogicLayer.Users;
using DataAccessLayer;
using DataAccessLayer.ProductRepository;

namespace ApplicationLayer
{
    public class Application {

        private WareHouse wareHouse;
        private DeliveryAgency delivery;
        private ProductRepository productRepo;
        public List<Administrators> Administrators { get;  }

        public Application() {
            wareHouse = new WareHouse();
            delivery = new DeliveryAgency();
            productRepo=new ProductRepository();
            Administrators=new List<Administrators> {new Administrators("Lev")};
    }

        public void DeliverGoods(int neededFoodProducts, int neededHealthCosmetics, int neededMakeUp) {
            Shipment shipment = delivery.Ship(neededFoodProducts, neededHealthCosmetics, neededMakeUp);
            wareHouse.ReceiveDelivery(shipment, productRepo);
        }
        public void DeleteProducts(string productId)
        {
            productRepo.DeleteProduct(productId);
        }

        public void UpdateProduct()
        {
            productRepo.UpdateProduct();
        }

        public void FindProducts(string productId) {
            productRepo.Retrieve(productId);
        }

        public bool checkAdmin(string userName) {
            foreach (var admin in Administrators) {
                if (admin.Name == userName) {
                    return true;
                }    
            }
            return false;
        }
    }
}
