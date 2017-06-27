using System;
using System.Collections.Generic;
using BusinessLogicLayer;
using BusinessLogicLayer.Partners;
using BusinessLogicLayer.Product;
using BusinessLogicLayer.Users;
using DataAccessLayer;
using DataAccessLayer.Repositories;

namespace ApplicationLayer
{
    public class Application{

        private readonly WareHouse wareHouse;
        private readonly DeliveryAgency delivery;
        private readonly ProductRepository<FoodProducts> productRepoFood;
        private readonly ProductRepository<HealthCosmetics> productRepoHealth;
        private readonly ProductRepository<MakeUp> productRepoMakeUp;
        private readonly UserRepository userRepo;


        public Application() {
            delivery = new DeliveryAgency();
            wareHouse = new WareHouse();
            productRepoFood = new ProductRepository<FoodProducts>();
            productRepoHealth = new ProductRepository<HealthCosmetics>();
            productRepoMakeUp = new ProductRepository<MakeUp>();
            userRepo = new UserRepository();
        }

        public void DeliverFoodProducts(int neededFoodProducts) {
            Shipment shipment = delivery.ShipFood(neededFoodProducts);
            wareHouse.ReceiveDeliveryFood(shipment, productRepoFood);
        }

        public void DeliverHealthCosmetics(int neededFoodProducts)
        {
            Shipment shipment = delivery.ShipHealthCosmetics(neededFoodProducts);
            wareHouse.ReceiveDeliveryHealth(shipment, productRepoHealth);
        }
        public void DeliverMakeUp(int neededMakeUp)
        {
            Shipment shipment = delivery.ShipMakeUp(neededMakeUp);
            wareHouse.ReceiveDeliveryMakeUp(shipment, productRepoMakeUp);
        }

        public void DeleteProducts(string productId)
        {
            try {productRepoFood.DeleteProduct(productId); }
            catch (TypeAccessException e) {
                Console.WriteLine("Sorry, there is no such product");
            }
        }

        public void UpdateProduct()
        {
            try { productRepoFood.UpdateProduct(); }
            catch (TypeAccessException e)
            {
                Console.WriteLine("Sorry, there is no such product");
            }
        }

        public Product FindProducts(string productId)
        {
            try {return productRepoFood.Retrieve(productId); }
            catch (TypeAccessException e) {
                Console.WriteLine("Sorry, there is no such product");
                return null;
            }
        }

        public bool checkAdmin(string userName) {
        List<Administrators> admins = userRepo.GetUsers();
            foreach (var admin in admins) {
                if (admin.Name == userName) {
                    return true;
                }    
            }
            return false;
        }

        public void LogUser(string currentUserName, string eventName) {
            Administrators currentUser = userRepo.Retrieve(currentUserName);
            Console.WriteLine(currentUser.LogEvent(eventName));
        }
    }
}
