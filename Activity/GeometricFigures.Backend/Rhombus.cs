using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures.Backend;

public class Rhombus : Square
{
    //Fields
    private double _d1;
    private double _d2;
    
    //Constructor
    public Rhombus(double a, string name,double d1,double d2) : base(a, name)
    
    {
        D1 = d1;
        D2 = d2;
    }
    //Properties 
    public double D1
    { 
        get => _d1;
        set => _d1 = ValidateD1(value);
    }

    public double D2
    {
        get => _d2;
        set => _d2 = ValidateD2(value); 
    }

    public override double GetArea() 
    {
        double x = D1 * D2 / 2;
        return x;
    }

    public override double GetPerimiter()
    {
        double y = A * 4;
        return y;
    }

    private double ValidateD1(double d1) 
    {
        if(d1 == 0)
        {
            throw new ArgumentException($"La diagonal mayor: {d1} no puede ser 0");
        }
        if (d1 < 0)
        {
            throw new ArgumentException($"La diagona mayor: {d1} no puede un número menor a 0");
        }
        return d1;
    }

    private double ValidateD2(double d2)
    {
        if (d2 == 0)
        {
            throw new ArgumentException($"La diagonal menor: {d2} no puede ser 0");
        }
        if (d2 < 0)
        {
            throw new ArgumentException($"La diagonal menor: {d2} no puede un número menor a 0");
        }
        return d2;
    }
}

