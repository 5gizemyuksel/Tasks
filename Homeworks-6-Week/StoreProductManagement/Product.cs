using System;

namespace StoreProductManagement;

public class Product
{
    public Product(string productName, decimal price, int stockQuantity)
    {
        ProductName = productName;
        Price = price;
        StockQuantity = stockQuantity;
    }

    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }




    public void CheckStock()
    {
        System.Console.WriteLine($"{ProductName} ürününün stok sayısı: {StockQuantity}");

    }


    public void UpdateStock(int updateStock)
    {
        if (updateStock > 0)
        {

            StockQuantity += updateStock;

            System.Console.WriteLine($"{ProductName} ürününün stoklarına {updateStock} ürün daha eklendi.\nGüncellenen Stok Sayısı: {StockQuantity}");
        }
        else
        {

            StockQuantity += updateStock;
            System.Console.WriteLine($"{ProductName} ürününün stoklarından {Math.Abs(updateStock)} ürün kadar çıkış yapıldı.\nGüncellenen Stok Sayısı: {StockQuantity}");

        }




    }
    public virtual void DisplayInfo()
    {
        System.Console.WriteLine($"Ürün ismi: {ProductName}\nÜrün Fiyatı: {Price}\nÜrün Stok: {StockQuantity}");
    }

}
