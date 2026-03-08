using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend;

public class Trapeze : Triangle
{
    //Fields
    private double _d;
    
    //Constructor
    public Trapeze(double a, string name, double b, double c, double h, double d) : base(a, name, b, c, h)
    {
        D = d;
    }

    //Properties 
    public double D
    {   get => _d; 
        set => _d = ValidateH(value);
    }

    public override double GetArea()
    {
        double x = (B + D) * H / 2;
        return x;
    }

    public override double GetPerimiter()
    {
        double y = A + B + C + D; 
        return y;
    }

    private double ValidateH(double D)
    {
        if (D == 0)
        {
            throw new ArgumentException($"El lado: {D} no puede ser 0");
        }
        if (D < 0)
        {
            throw new ArgumentException($"El lado: {D} no puede ser un número negativo");
        }
        return D;
    }

}
