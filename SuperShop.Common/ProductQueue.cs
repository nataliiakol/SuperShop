using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Product;

namespace SuperShop.Common
{
    class ProductQueue {
        private readonly List<Product> vProductList;
        public ProductQueue() {
            vProductList=new List<Product>();
        }

        public void Push(Product product) {
            vProductList.Add(product);
        }

        public Product Pull() {
            Product deletedProduct=vProductList[0];
            vProductList.RemoveAt(0);
            return deletedProduct;
        }
    }
}
