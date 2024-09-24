using System;

namespace StoreProductManagement;

public class ElectronicProduct : Product
{
    public ElectronicProduct(string productName, decimal price, int stockQuantity, string productType) : base(productName, price, stockQuantity)
    {
        ProductType = productType;
    }
    public string ProductType { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Ürün tipi: {ProductType}");
    }

}
