namespace Question10;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("alt sınırı giriniz: ");
        int numberLow=int.Parse(Console.ReadLine());

        System.Console.Write("üst sınırı giriniz: ");
        int numberUp=int.Parse(Console.ReadLine());
        int sonuc=1;
         
         
        for (int i = numberLow; i<=numberUp; i++)
        {
            
            sonuc*=i;
              
        }
        System.Console.WriteLine(sonuc);
    }
}
