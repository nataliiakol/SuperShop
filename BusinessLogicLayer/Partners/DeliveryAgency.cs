using System.ComponentModel;
using BusinessLogicLayer.Product;

namespace BusinessLogicLayer.Partners
{
   public  class DeliveryAgency : BusinessLogicLayer.Partners.Partners{

       Shipment shipment = new Shipment();

        /* public Shipment<T> Ship(int quantityFood, int quantityHealth, int quantityMakeUp) {
             var shipment = new Shipment();
             shipment.AddFoodProduct(GetFoodProducts(quantityFood));
             shipment.AddHealthCosmeticsProduct(GetHealthProducts(quantityHealth));
             shipment.AddMakeUpProduct(GetMakeUProducts(quantityMakeUp));
             return shipment;
         }*/

       public Shipment ShipFood(int quantity)
       {
           shipment.AddFoodProduct(new FoodProducts() { InstanceCount = quantity});
           return shipment;
       }

       public Shipment ShipHealthCosmetics(int quantity)
       {
           shipment.AddHealthCosmeticsProduct(new HealthCosmetics() { InstanceCount = quantity });
           return shipment;
       }
       public Shipment ShipMakeUp(int quantity)
       {
           shipment.AddMakeUpProduct(new MakeUp() { InstanceCount = quantity });
           return shipment;
       }

    }
}
