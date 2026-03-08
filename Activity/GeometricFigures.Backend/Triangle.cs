using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend;

public class Triangle : Rectangle
{
    //Fields
    private double _c;
    private double _h;

    //Constructor 
    public Triangle(double a, string name, double b, double c, double h) : base(a, name, b)
    {
        C = c;
        H = h;
    }

    //Properties
    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    //Methods

    public override double GetArea()
    {
        double x = (B * H) / 2;
        return x;
    }

    public override double GetPerimiter()
    {
        double y = A + B + C;
        return y;
    }

    private double ValidateC(double C) 
    {
        if (C == 0)
        {
            throw new ArgumentException($"El lado: {C} no puede ser 0");
        }
        if (C < 0)
        {
            throw new ArgumentException($"El lado: {C} no puede ser un número negativo");
        }
        return C;
    }

    private double ValidateH(double H)
    {
        if (H == 0)
        {
            throw new ArgumentException($"La altura: {H} no puede ser 0");
        }
        if (H < 0)
        {
            throw new ArgumentException($"La altura: {H} no puede ser un número negativo");
        }
        return H;
    }

}
