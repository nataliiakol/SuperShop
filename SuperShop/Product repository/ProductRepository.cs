using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using SuperShop.Product;

namespace SuperShop.Product_repository
{
    public class ProductRepository {
        public static Product.Product Retrieve(int productID) {
            return new FoodProducts(1);
        }

        public static List<Product.Product> Retrieve() {
            return new List<Product.Product>();
        }

        public static bool SaveProducts(List<Product.Product> Products) {
            return true;
            foreach (Product.Product product in Products)
            {
                Console.WriteLine(product.ProductID + product.InstanceCount);
            }
        }

        public static bool DeleteProduct(int productId, int instanceCount) {
            Product.Product productToDelete = Retrieve(productId);
            if (productToDelete.InstanceCount >= instanceCount) {
                productToDelete.InstanceCount -= instanceCount;
                return true;
            }
            else {                
                Console.WriteLine("You can't delete more items then you have");
                return false;
            }
        }

        public static void UpdateProduct(int productId, Product.Product product) {
            Product.Product productToDelete = Retrieve(productId);
        }
    }
}
