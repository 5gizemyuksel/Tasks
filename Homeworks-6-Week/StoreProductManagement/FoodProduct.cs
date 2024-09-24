using System;

namespace StoreProductManagement;

public class FoodProduct : Product
{
    public FoodProduct(string productName, decimal price, int stockQuantity, string expirationDate) : base(productName, price, stockQuantity)
    {
        ExpirationDate = expirationDate;
    }
    public string ExpirationDate { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Son Kullanma Tarihi: {ExpirationDate}");
    }

}
