using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using SuperShop.Product;

namespace SuperShop.Product_repository
{
    public  class ProductRepository {
        public static Product.Product Retrieve(int productID) {
            return new FoodProducts(productID);
        }

        public List<Product.Product> Retreive() {
            return null;
        }

        public static void SaveProducts(List<Product.Product> Products) {
            foreach (Product.Product product in Products)
            {
                Console.WriteLine(product.ProductID + product.InstanceCount);
            }
        }
        public static void DeleteProduct(int productId, int instanceCount) {

        }
        public static void UpdateProduct(int productId, Product.Product product) {

        }
    }
}
