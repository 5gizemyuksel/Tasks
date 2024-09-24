using System;
using System.Numerics;
using System.Xml.XPath;

namespace Calculator;

public class Calculator 
{
     
    public double Add(double number1,double number2)
    {
        double total = number1 + number2;
        System.Console.WriteLine(total);
        return total;
    }

    public double Subtract(double number1, double number2)
    {
        double result = number1 - number2;
        System.Console.WriteLine(result);
        return result;
    }

    public double Multiply(double number1, double number2)
    {
        double result = number1 * number2;
        System.Console.WriteLine(result);
        return result;
    }
    public double Divide(double number1, double number2)
    {
        double result=0;
        if (number2!=0)
        {
             result+=number1/number2;
            System.Console.WriteLine(result);
            
        }else
        {
            System.Console.WriteLine("0'a Bölünemez!");
            
        }
        return result;
    }

}
