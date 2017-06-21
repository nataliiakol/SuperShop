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
        public List<Product.FoodProducts> FoodProducts { get; set; }
        public List<Product.HealthCosmetics> HealthCosmeticsProducts { get; set; }
        public List<Product.MakeUp> MakeUpProducts { get; set; }

        public float ShipmentCost { get; private set; }

        public DateTimeOffset ShipmetDateTime { get; private set; }

        public Shipment() {
            ShipmentCost = 0;
            FoodProducts = new List<Product.FoodProducts>();
            HealthCosmeticsProducts = new List<Product.HealthCosmetics>();
            MakeUpProducts = new List<Product.MakeUp>();
            ShipmetDateTime =DateTimeOffset.Now;
        }

        public void AddFoodProduct(Product.FoodProducts foodProduct)
        {
            FoodProducts.Add(foodProduct);
            ShipmentCost += foodProduct.CurrentPrice;
        }

        public void AddHealthCosmeticsProduct(Product.HealthCosmetics healthCosmeticsProduct)
        {
            HealthCosmeticsProducts.Add(healthCosmeticsProduct);
            ShipmentCost += healthCosmeticsProduct.CurrentPrice;
        }

        public void AddMakeUpProduct(Product.MakeUp MakeUpProduct)
        {
            MakeUpProducts.Add(MakeUpProduct);
            ShipmentCost += MakeUpProduct.CurrentPrice;
        }
    }
    }
