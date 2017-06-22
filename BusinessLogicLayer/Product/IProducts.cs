using System;

namespace BusinessLogicLayer.Product
{
    internal interface IProducts
    {
        string ProductID { get; set; }
        float CurrentPrice { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime ExpirationDateTime { get; set; }
        int InstanceCount { get; set; }

        bool Validate();

        bool CheckExpirationDate();

    }
}
