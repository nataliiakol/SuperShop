using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using BusinessLogicLayer.Product;
using DataAccessLayer.ProductRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ProductRepositoryTests {

    [TestClass]
    public class ProductRepositoryTests {
        public ProductRepository<FoodProducts> repo;
        public string path = @"C:\GitRepo\foodProducts";

        [TestMethod]
        public void TestDelete() {
            repo = new ProductRepository<FoodProducts>();
            try {
                repo.DeleteProduct("wrongId");
            }
            catch (TypeAccessException e) {
                Console.WriteLine(e);
                Assert.IsNotNull(e);
            }
        }

        [TestMethod]
        public void TestRetrieve() {
            repo = new ProductRepository<FoodProducts>();
            try {
                Product product = repo.Retrieve("WrongId");
            }
            catch (TypeAccessException e) {
                Console.WriteLine(e);
                Assert.IsNotNull(e);
            }
        }

    }
}