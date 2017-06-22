using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using BusinessLogicLayer.Product;

namespace DataAccessLayer.ProductRepository
{
    public class ProductRepository {
        public Product Retrieve(int productID) {
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

        public List<Product> GetFoodProducts(Type type)
        {
            XmlSerializer serializer = new XmlSerializer(type);
            string fileName = GetFileName(type);
            string path = Path.Combine("C:/GitRepo", fileName);
            TextReader reader = new StringReader(path);          
            List<Product> products;
            products = (List<Product>)serializer.Deserialize(reader);
            reader.Close();
            return products;
        }

        private string GetFileName(Type type) {
            if (typeof(List<FoodProducts>) == type) {
                return "foodProducts";
            }
            else if (typeof(List<FoodProducts>) == type)
            {
                return "foodProducts";
            }
        }


        public void SaveProducts(List<FoodProducts> foodProducts, List<HealthCosmetics> healthCosmeticsProducts, List<MakeUp> makeUpProducts) {
            WriteToFile("foodProducts", typeof(List<FoodProducts>), foodProducts);
            WriteToFile("healthCosmeticsProducts", typeof(List<HealthCosmetics>), healthCosmeticsProducts);
            WriteToFile("makeUpProducts", typeof(List<MakeUp>), makeUpProducts);       
        }

        public void DeleteProduct(int productId, int instanceCount) {
            Product productToDelete = Retrieve(productId);
            if (productToDelete.InstanceCount >= instanceCount) {
                productToDelete.InstanceCount -= instanceCount;                
            }
            else {                
                Console.WriteLine("You can't delete more items then you have");                
            }
        }

        public void UpdateProduct(int productId, Product product) {
            //GetFoodProducts()
            Product productToUpdate = Retrieve(productId);
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
