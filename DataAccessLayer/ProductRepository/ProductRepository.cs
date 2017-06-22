using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Xml.Serialization;
using BusinessLogicLayer.Product;

namespace DataAccessLayer.ProductRepository
{
    public class ProductRepository {
        private List<Product> productsInContext;
        private Type productListType;
        public Product Retrieve(string productId) {
            productListType = GetTypeFromProductId(productId);
            productsInContext = GetProducts(productListType);
            foreach (Product product in productsInContext) {
                if (product.ProductID == productId) {
                    return product;
                }          
            }
            throw new TypeAccessException("No such product!");
        }

        private Type GetTypeFromProductId(string productID) {
            string type = productID.Substring(0, 2);
            switch (type) {
                case "01":
                    return typeof(List<FoodProducts>);
                case "02":
                    return typeof(List<HealthCosmetics>);
                case "03":
                    return typeof(List<MakeUp>);
                default:
                    throw new TypeAccessException("Wrong type!");
        }

        }

        public List<Product> GetProducts(Type type)
        {
            XmlSerializer serializer = new XmlSerializer(type);
            string fileName = GetFileName(type);
            string path = Path.Combine("C:/GitRepo", fileName);
            TextReader reader = new StringReader(path);
            List<Product> products = (List<Product>)serializer.Deserialize(reader);
            reader.Close();
            return products;
        }

        private string GetFileName(Type type) {
            if (typeof(List<FoodProducts>) == type) {
                return "foodProducts";
            }
            else if (typeof(List<HealthCosmetics>) == type) {
                return "HealthCosmetics";
            }
            else if (typeof(List<MakeUp>) == type)
            {
                return "makeUp";
            }
            else {
               throw new TypeAccessException("Wrong type!");
            }
        }

        public void SaveProducts(List<FoodProducts> foodProducts, List<HealthCosmetics> healthCosmeticsProducts, List<MakeUp> makeUpProducts) {
            WriteToFile("foodProducts", typeof(List<FoodProducts>), foodProducts);
            WriteToFile("healthCosmeticsProducts", typeof(List<HealthCosmetics>), healthCosmeticsProducts);
            WriteToFile("makeUpProducts", typeof(List<MakeUp>), makeUpProducts);       
        }

        public void AddProducts(List<FoodProducts> foodProducts, List<HealthCosmetics> healthCosmeticsProducts,
            List<MakeUp> makeUpProducts) {
            List<Product> newFoods = GetProducts(typeof(List<FoodProducts>));
            newFoods.AddRange(foodProducts);
            WriteToFile(GetFileName(typeof(List<FoodProducts>)), typeof(List<FoodProducts>), newFoods);
        }

        public void DeleteProduct(string productId) {
            Type type = GetTypeFromProductId(productId);
            List<Product> products = GetProducts(type);
            foreach (Product product in products)
            {
                if (product.ProductID == productId)
                {
                    products.Remove(product);
                    break;
                }
            }
            WriteToFile(GetFileName(type), type, products);
        }

        public void UpdateProduct() {
            WriteToFile(GetFileName(productListType), productListType, productsInContext);
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
