using System;
using System.Collections.Generic;
using BusinessLogicLayer.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer.Product_repository;

namespace ProductRepositoryTests {

    [TestClass]
    public class ProductRepositoryTests {
        [TestMethod]
        public void TestRetrieve() {
            Product product = ProductRepository.Retrieve(1);
            Assert.IsNotNull(product);
        }

        [TestMethod]
        public void TestRetrieveList() {
            List<Product> productList = ProductRepository.Retrieve();
            Assert.IsNotNull(productList);
        }

        [TestMethod]
        public void TestDeleteProduct() {
            bool deletionIsOk = ProductRepository.DeleteProduct(1,5);
            Assert.Equals(false, deletionIsOk);
        }

        [TestMethod]
        public void TestSaveProduct()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new FoodProducts(1));
            productList.Add(new FoodProducts(2));
            productList.Add(new FoodProducts(3));
            Assert.AreEqual(true, ProductRepository.SaveProducts(productList));
        }
    }
}