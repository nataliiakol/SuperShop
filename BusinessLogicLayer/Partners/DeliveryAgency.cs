using BusinessLogicLayer.Product;

namespace BusinessLogicLayer.Partners
{
   public  class DeliveryAgency : BusinessLogicLayer.Partners.Partners {

       public Shipment Ship(int quantityFood, int quantityHealth, int quantityMakeUp) {
           var shipment = new Shipment();
           shipment.AddFoodProduct(GetFoodProducts(quantityFood));
           shipment.AddHealthCosmeticsProduct(GetHealthProducts(quantityHealth));
           shipment.AddMakeUpProduct(GetMakeUProducts(quantityMakeUp));
           return shipment;
       }

       private FoodProducts GetFoodProducts(int quantityFood) {
           return new FoodProducts() {InstanceCount = quantityFood};
       }

       private HealthCosmetics GetHealthProducts(int quantityHealth)
       {
           return new HealthCosmetics() { InstanceCount = quantityHealth };
       }

       private MakeUp GetMakeUProducts(int quantityMakeUp)
       {
           return new MakeUp() { InstanceCount = quantityMakeUp};
       }

   }
}
