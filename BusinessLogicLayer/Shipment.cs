using System;
using System.Collections.Generic;
using BusinessLogicLayer.Product;

namespace BusinessLogicLayer
{
    public class Shipment
    {
        public List<FoodProducts> FoodProducts { get; set; }
        public List<HealthCosmetics> HealthCosmeticsProducts { get; set; }
        public List<MakeUp> MakeUpProducts { get; set; }

        public float ShipmentCost { get; private set; }

        public DateTimeOffset ShipmetDateTime { get; private set; }

        public Shipment() {
            ShipmentCost = 0;
            FoodProducts = new List<FoodProducts>();
            HealthCosmeticsProducts = new List<HealthCosmetics>();
            MakeUpProducts = new List<MakeUp>();
            ShipmetDateTime =DateTimeOffset.Now;
        }

        public void AddFoodProduct(FoodProducts foodProduct)
        {
            FoodProducts.Add(foodProduct);
            ShipmentCost += foodProduct.CurrentPrice;
        }

        public void AddHealthCosmeticsProduct(HealthCosmetics healthCosmeticsProduct)
        {
            HealthCosmeticsProducts.Add(healthCosmeticsProduct);
            ShipmentCost += healthCosmeticsProduct.CurrentPrice;
        }

        public void AddMakeUpProduct(MakeUp MakeUpProduct)
        {
            MakeUpProducts.Add(MakeUpProduct);
            ShipmentCost += MakeUpProduct.CurrentPrice;
        }

    }
    }
