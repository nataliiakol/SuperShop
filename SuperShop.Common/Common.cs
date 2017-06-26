using System;
using System.Collections.Generic;
using BusinessLogicLayer.Product;

namespace SuperShop.Common {
    public class Common {
        public string GetFileName(Type type)
        {
            if (typeof(List<FoodProducts>) == type)
            {
                return "foodProducts";
            }
            else if (typeof(List<HealthCosmetics>) == type)
            {
                return "healthCosmeticsProducts";
            }
            else if (typeof(List<MakeUp>) == type)
            {
                return "makeUpProducts";
            }
            else
            {
                throw new TypeAccessException("Wrong type!");
            }
        }
    }
}