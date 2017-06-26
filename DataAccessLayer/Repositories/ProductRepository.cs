using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Xml.Serialization;
using BusinessLogicLayer.Product;
using SuperShop.Common;

namespace DataAccessLayer.ProductRepository
{
    public class ProductRepository <T> where T: Product{

        private List<T> vProductsInContext;
        private static readonly Type vProductListType = typeof(List<T>);
        private static readonly XmlSerializer vSerializer = new XmlSerializer(vProductListType);
        private static readonly Common vCommon = new Common();
        private static readonly string vFileName = vCommon.GetFileName(vProductListType);
        private static readonly string vPath = @"C:\GitRepo\" + vFileName;

        public void AddProducts(List<T> Products){
            List<T> newProducts = GetProducts();
            newProducts.AddRange(Products);
            WriteToFile(newProducts);
        }

        public void DeleteProduct(string productId) {
            List<T> products = GetProducts();
            foreach (T product in products)
            {
                if (product.ProductID == productId)
                {
                    products.Remove(product);
                    break;
                }
            }
            WriteToFile(products);
        }

        public void UpdateProduct() {
            WriteToFile(vProductsInContext);
        }

        public Product Retrieve(string productId) {
            vProductsInContext = GetProducts();
            foreach (T product in vProductsInContext) {
                if (product.ProductID == productId) {
                    return product;
                }          
            }
            throw new TypeAccessException("No such product!");
        }

        public List<T> GetProducts() {
            TextReader reader = new StreamReader(File.Open(vPath, FileMode.OpenOrCreate));
            List<T> products = (List<T>)vSerializer.Deserialize(reader);
            reader.Close();
            return products;
        }

        public void WriteToFile(object file) {
            StreamWriter writer = new StreamWriter(vPath);           
            vSerializer.Serialize(writer, file);      
            writer.Close();
        }


        /*  public void SaveProducts(List<FoodProducts> foodProducts, List<HealthCosmetics> healthCosmeticsProducts, List<MakeUp> makeUpProducts)
        {
            WriteToFile("foodProducts", typeof(List<FoodProducts>), foodProducts);
            WriteToFile("healthCosmeticsProducts", typeof(List<HealthCosmetics>), healthCosmeticsProducts);
            WriteToFile("makeUpProducts", typeof(List<MakeUp>), makeUpProducts);
        }*/
    }
}
