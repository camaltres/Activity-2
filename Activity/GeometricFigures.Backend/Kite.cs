using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend;
public class Kite : Rhombus
{
    //Fields
    private double _b;

    //Constructor
    public Kite(double a, string name, double d1, double d2, double b) : base(a, name, d1, d2)
    {
        B = b;
    }
    //Properties
    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }
    //Methods
    public override double GetArea()
    {
        double x = (D1 * D2) / 2;
        return x;
    }

    public override double GetPerimiter()
    {
        double y = 2 * (A + B);
        return y;
    }

    private double ValidateB(double B)
    {
        if (B == 0)
        {
            throw new ArgumentException($"El lado: {B} no puede ser 0");
        }
        if (B < 0)
        {
            throw new ArgumentException($"El lado: {B} no puede ser un número negativo");
        }
        return B;
    }


}
