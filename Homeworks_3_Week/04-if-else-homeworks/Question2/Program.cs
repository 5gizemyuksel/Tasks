namespace Question2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı giriniz: ");

        int numberInt1 = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("İkinci sayıyı giriniz: ");
        int numberInt2 = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("üçüncü sayıyı giriniz: ");


        int numberInt3 = Convert.ToInt32(Console.ReadLine());

        int[] numbers = { numberInt1, numberInt2, numberInt3 };

        Array.Sort(numbers);
        Array.Reverse(numbers);


        System.Console.WriteLine($"Sonuçlar büyükten küçüğe sıralandı: ");

        foreach (int number in numbers)
        {
            System.Console.Write(number);
        }





    }
}
