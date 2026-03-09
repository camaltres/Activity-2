using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend;

public class Circle : GeometricFigure
{
    //Field 
    double _r;

    //Constructor
    public Circle(double r, string name)
    {
        Name = name;
        R = r;
    }

    //Properties
    public double R
    {
        get => _r;
        set => _r = ValideteR(value);
    }

    //Methods
    public override double GetArea()
    {
        double radius = R;
        double x = Math.PI * Math.Pow(radius, 2);
        return x;
    }
    public override double GetPerimiter()
    {
        double radius = R;
        double y = 2 * Math.PI * radius;
        return y;
    }
    private double ValideteR(double r)
    {
        if (r == 0)
        {
            throw new ArgumentException($"El radio: {r} no puede ser 0");
        }
        if (r < 0)
        {
            throw new ArgumentException($"El radio: {r} no puede ser un número negativo");
        }
        return r;
    }
}
