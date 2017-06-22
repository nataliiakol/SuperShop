namespace BusinessLogicLayer.Product
{
    public class HealthCosmetics : Cosmetics
    {
        public HealthCosmetics(int productID) {
            ProductID = productID;
        }

        public HealthCosmetics()
        {
            
        }

        public override bool Validate() {
            return true;
        }
    }
}
