using System;

namespace SuperShop.Product
{
    public abstract class Product : IProducts{

        public int ProductID { get; set; }
        public float CurrentPrice { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ExpirationDateTime { get; set; }
        public int InstanceCount { get; set; }

        public abstract bool Validate();

        public bool CheckExpirationDate() {
            return ExpirationDateTime <= DateTime.Today;
        }
    }
}
