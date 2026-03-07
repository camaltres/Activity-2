using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend;

public class Rectangle : Square
{
    //Fields 
    private double _b;

    //Constructor
    public Rectangle(double a, string name, double b) : base(a, name)
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
        double x = A * B;
        return x;
    }

    public override double GetPerimiter()
    {
        double y = (A + B) * 2;
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
