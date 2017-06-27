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
        private const int LIMIT = 15;

        public void AddProducts(List<T> Products){
            GetProducts();
            if (vProductsInContext.Count == 5) {
                throw new LimitException();
            }
            vProductsInContext.AddRange(Products);
            WriteToFile(vProductsInContext);
        }

        public void DeleteProduct(string productId) {
            GetProducts();
            foreach (T product in vProductsInContext)
            {
                if (product.ProductID == productId) {
                    vProductsInContext.Remove(product);
                    break;
                }
                else {
                    throw new TypeAccessException("No such product!");
                }
            }
            WriteToFile(vProductsInContext);
        }

        public void UpdateProduct() {
            WriteToFile(vProductsInContext);
        }

        public Product Retrieve(string productId) {
            GetProducts();
            foreach (T product in vProductsInContext) {
                if (product.ProductID == productId) {
                    return product;
                }          
            }
            throw new TypeAccessException("No such product!");
        }

        private void GetProducts() {
            TextReader reader = new StreamReader(File.Open(vPath, FileMode.OpenOrCreate));
            vProductsInContext = (List<T>)vSerializer.Deserialize(reader);
            reader.Close();
        }

        private void WriteToFile(object file) {
            StreamWriter writer = new StreamWriter(vPath);           
            vSerializer.Serialize(writer, file);      
            writer.Close();
        }
    }
}
