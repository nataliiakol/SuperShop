namespace SuperShop.Product
{
    public class HealthCosmetics : Cosmetics
    {
        public HealthCosmetics(int productID) {
            ProductID = productID;
        }

        public override bool Validate() {
            return true;
        }
    }
}
