namespace SuperShop.Product
{
    public class FoodProducts : Product { 

        public float Weight { get; set; }

        public FoodProducts(int productID){
            ProductID = productID;
        }

        public override bool Validate() {
            var validResults = true;
            return validResults;
        }
    }
}
