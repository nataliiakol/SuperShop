using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using SuperShop.Partners;

namespace SuperShop
{
    public class Shipment {
        public List<Product.Product> Products { get; set; }

        public float ShipmentCost { get; private set; }

        public DateTimeOffset ShipmetDateTime { get; private set; }

        public Shipment() {
            ShipmentCost = 0;
            Products=new List<Product.Product>();
            ShipmetDateTime=DateTimeOffset.Now;
        }

        public void Add(Product.Product product) {
            Products.Add(product);
            ShipmentCost += product.CurrentPrice;
        }
    }
    }
