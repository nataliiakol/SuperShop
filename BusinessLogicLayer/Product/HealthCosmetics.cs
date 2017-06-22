namespace BusinessLogicLayer.Product
{
    public class HealthCosmetics : Cosmetics
    {

        public HealthCosmetics() : base("02") {
            
        }

        public override bool Validate() {
            return true;
        }
    }
}
