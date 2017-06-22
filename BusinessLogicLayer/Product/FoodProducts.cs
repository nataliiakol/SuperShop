namespace BusinessLogicLayer.Product
{
    public class FoodProducts : Product { 

        public float Weight { get; set; }

        public FoodProducts() : base("01") {

        }

        public override bool Validate() {
            var validResults = true;
            return validResults;
            
        }
    }
}
