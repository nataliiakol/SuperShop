using SuperShop.Product;

namespace SuperShop.Partners
{
   public  class DeliveryAgency : Partners {

       public Shipment Ship(int quantityFood, int quantityHealth, int quantityMakeUp) {
           var shipment = new Shipment();
           shipment.Add(GetFoodProducts(quantityFood));
           shipment.Add(GetHealthProducts(quantityHealth));
           shipment.Add(GetMakeUProducts(quantityMakeUp));
           return shipment;
       }

       private FoodProducts GetFoodProducts(int quantityFood) {
           return new FoodProducts(1) {InstanceCount = quantityFood};
       }

       private HealthCosmetics GetHealthProducts(int quantityHealth)
       {
           return new HealthCosmetics(1) { InstanceCount = quantityHealth };
       }

       private MakeUp GetMakeUProducts(int quantityMakeUp)
       {
           return new MakeUp() { InstanceCount = quantityMakeUp};
       }

   }
}
