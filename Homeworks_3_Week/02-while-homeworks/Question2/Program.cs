namespace Question2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("bir metin giriniz: ");
        string input = Console.ReadLine();
        string result = "";

        int i = 0;

        while (i < input.Length)
        {
            char word = input[i];
            if (char.IsLetter(word))
            {
                result += char.ToUpper(word);
            }
            else
            {
                result += word;
            }

            i++;
        }

        System.Console.WriteLine(result);

    }
}
