using BusinessLogicLayer;
using BusinessLogicLayer.Partners;
using BusinessLogicLayer.Product;
using DataAccessLayer;
using DataAccessLayer.ProductRepository;

namespace ApplicationLayer
{
    public class Application {

        private WareHouse wareHouse;
        private DeliveryAgency delivery;
        private ProductRepository productRepo;

        public Application() {
            wareHouse = new WareHouse();
            delivery = new DeliveryAgency();
            productRepo=new ProductRepository();
    }

    public void DeliverGoods(int neededFoodProducts, int neededHealthCosmetics, int neededMakeUp) {
            Shipment shipment = delivery.Ship(neededFoodProducts, neededHealthCosmetics, neededMakeUp);
            wareHouse.ReceiveDelivery(shipment, productRepo);
        }
    public void DeleteProducts(int productId, int instanceCount)
        {
            productRepo.DeleteProduct(productId, instanceCount);
        }

    public void UpdateProduct(int productId, string name, string description)
        {
            productRepo.UpdateProduct(productId, new FoodProducts(1));
        }

    public void FindProducts(int productId) {
        productRepo.Retrieve(productId);
        }
        

    }
}
