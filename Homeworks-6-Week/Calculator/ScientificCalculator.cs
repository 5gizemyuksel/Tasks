using System;

namespace Calculator;

public class ScientificCalculator : Calculator
{
    public double Sin(double aci)
    {
        double sin = Math.Sin(aci* Math.PI/180);
        System.Console.WriteLine(sin);
        return sin;
    }

    public double Cos(double aci)
    {
        double cos= Math.Cos(aci*Math.PI / 180);
        System.Console.WriteLine(cos);
        return cos;
    }
    public double Tan(double aci)
    {
        double tan= Math.Tan(aci* Math.PI / 180);
        System.Console.WriteLine(tan);
        return tan;
    }



}
