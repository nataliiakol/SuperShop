using System;

namespace BusinessLogicLayer.Product
{
    public abstract class Product : IProducts{

        public string ProductID { get; set; }
        public float CurrentPrice { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ExpirationDateTime { get; set; }
        public int InstanceCount { get; set; }
        public string ProductTypeCode { get; }

        public abstract bool Validate();

        public bool CheckExpirationDate() {
            return ExpirationDateTime <= DateTime.Today;
        }

        public Product(string ProductTypeCode) {
            this.ProductTypeCode = ProductTypeCode;
            ProductID = ProductTypeCode + GetRandomStringId();
        }

        private string GetRandomStringId() {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[5];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            return new String(stringChars);
        }
    }
}
