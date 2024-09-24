namespace StoreProductManagement;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("MacBook", 30000, 20);
        product.DisplayInfo();
        System.Console.WriteLine("*************");
        product.CheckStock();
        System.Console.WriteLine("*****************");
        product.UpdateStock(1);
        System.Console.WriteLine("******************");

        FoodProduct foodProduct = new FoodProduct("Yoğurt", 90, 15, "10.10.2024");

        foodProduct.DisplayInfo();
        System.Console.WriteLine("******************");

        foodProduct.CheckStock();
        System.Console.WriteLine("******************");

        foodProduct.UpdateStock(3);
        System.Console.WriteLine("******************");

        foodProduct.CheckStock();
        System.Console.WriteLine("******************");

        ElectronicProduct electronicProduct = new ElectronicProduct("Iphone 14 Pro", 700000, 13, "Telefon");
        electronicProduct.DisplayInfo();
        System.Console.WriteLine("******************");

        electronicProduct.CheckStock();
        System.Console.WriteLine("******************");

        electronicProduct.UpdateStock(-5);
        System.Console.WriteLine("******************");



    }
}
