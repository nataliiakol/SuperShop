using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Xml.Serialization;
using SuperShop.Product;

namespace SuperShop.Product_repository
{
    public class ProductRepository {
        public Product.Product Retrieve(int productID) {
            List<FoodProducts> foodProducts = GetFoodProducts();
            FoodProducts returnedProduct= new FoodProducts();
            foreach (FoodProducts product in foodProducts) {
                if (product.ProductID == productID) {
                    returnedProduct = product;
                }          
            }
            return returnedProduct;
        }

    public List<FoodProducts> GetFoodProducts() {
            XmlSerializer serializer=new XmlSerializer(typeof(List<FoodProducts>));
            TextReader reader = new StringReader("foodProducts");
            string path = Path.Combine("C:/GitRepo", "");
            List<FoodProducts> foodProducts;
            foodProducts = (List<FoodProducts>) serializer.Deserialize(reader);
            reader.Close();
            return foodProducts;
        }

        public void SaveProducts(List<Product.FoodProducts> foodProducts, List<HealthCosmetics> healthCosmeticsProducts, List<MakeUp> makeUpProducts) {
            WriteToFile("foodProducts", typeof(List<Product.FoodProducts>), foodProducts);
            WriteToFile("healthCosmeticsProducts", typeof(List<HealthCosmetics>), healthCosmeticsProducts);
            WriteToFile("makeUpProducts", typeof(List<MakeUp>), makeUpProducts);       
        }

        public void DeleteProduct(int productId, int instanceCount) {
            Product.Product productToDelete = Retrieve(productId);
            if (productToDelete.InstanceCount >= instanceCount) {
                productToDelete.InstanceCount -= instanceCount;                
            }
            else {                
                Console.WriteLine("You can't delete more items then you have");                
            }
        }

        public void UpdateProduct(int productId, Product.Product product) {
            Product.Product productToUpdate = Retrieve(productId);
        }

        public void WriteToFile(string fileName, Type type, Object file) {
            XmlSerializer Serializer = new XmlSerializer(type);
            string path = Path.Combine("C:/GitRepo", fileName);
            StreamWriter writer = new StreamWriter(path);           
            Serializer.Serialize(writer, file);      
            writer.Close();
        }
    }
}
