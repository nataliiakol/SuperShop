using System;

namespace SuperShop.Product
{
    public abstract class Product {

        public int ProductID { get; set; }
        public float CurrentPrice { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ExpirationDateTime { get; set; }
        public int InstanceCount { get; set; }

        public abstract bool Validate();
        protected bool CheckExpirationDate() {
            return ExpirationDateTime <= DateTime.Today;
        }
    }
}
