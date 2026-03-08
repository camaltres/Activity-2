using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend;

public class Parallelogram : Rectangle
{
    //Fields 
    private double _h;

    //Constructor 
    public Parallelogram(double a, string name, double b, double h) : base(a, name, b)
    {
        H = h;
    }

    //Properties
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    public override double GetArea()
    {
        double x = B * H;
        return x;
    }

    public override double GetPerimiter()
    {
        double y = 2 * (A + B);
        return y;
    }

    private double ValidateH(double H)
    {
        if (H == 0)
        {
            throw new ArgumentException($"La altura: {H} no puede ser 0");
        }
        if (H < 0)
        {
            throw new ArgumentException($"La altura:{H} no puede ser un número negativo");
        }
        return H;
    }



}
