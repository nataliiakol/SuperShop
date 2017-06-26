using System;
using System.Collections.Generic;
using BusinessLogicLayer.Product;
using DataAccessLayer.ProductRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ProductRepositoryTests {

    [TestClass]
    public class ProductRepositoryTests {
        private ProductRepository<FoodProducts> repo = new ProductRepository<FoodProducts>();
        [TestMethod]
        public void TestRetrieve() {
            Product product = repo.Retrieve("01");
            Assert.IsNotNull(product);
        }





    }
}