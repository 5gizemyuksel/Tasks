namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        calculator.Add(4, 5);
        System.Console.WriteLine();
        System.Console.WriteLine();
        calculator.Divide(8, 4);
        System.Console.WriteLine();
        System.Console.WriteLine();

        ScientificCalculator scientificCalculator = new ScientificCalculator();
        scientificCalculator.Cos(30);
        System.Console.WriteLine();
        System.Console.WriteLine();


        scientificCalculator.Multiply(5, 5);
        System.Console.WriteLine();
        System.Console.WriteLine();
        scientificCalculator.Subtract(5, 5);
        System.Console.WriteLine();
        System.Console.WriteLine();
        scientificCalculator.Sin(90);
        System.Console.WriteLine();
        System.Console.WriteLine();
        scientificCalculator.Tan(30);
        System.Console.WriteLine();
        System.Console.WriteLine();
    }
}
