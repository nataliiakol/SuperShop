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
            return new List<Product.Product>();
        }

        public static void SaveProducts(List<Product.Product> Products) {
            foreach (Product.Product product in Products)
            {
                Console.WriteLine(product.ProductID + product.InstanceCount);
            }
        }
        public static void DeleteProduct(int productId, int instanceCount) {
            Product.Product productToDelete = Retrieve(productId);
            if (productToDelete.InstanceCount >= instanceCount) {
                productToDelete.InstanceCount -= instanceCount;
            }
            else { Console.WriteLine("You can't delete more items then you have");}
        }
        public static void UpdateProduct(int productId, Product.Product product) {
            Product.Product productToDelete = Retrieve(productId);

        }
    }
}
