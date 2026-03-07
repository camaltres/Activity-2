using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace GeometricFigures.Backend;

public class Square : GeometricFigures
{
    //Fields
    private double _a;

    //Constructor
    public Square(double a, string name) 
    {
        A = a;
        Name = name;
    }

    //Properties
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    //Methods
    public override double GetArea()
    {
        double l1 = A;
        double potence = Math.Pow(l1, 2);

        return potence;
    }

    public override double GetPerimiter()
    {
        double l1 = A;
        double p1 = l1 * 4;
        return p1;
    }

    private double ValidateA(double l1) 
    {
        if (l1 == 0)
        {
            throw new ArgumentException($"El lado: {l1} no puede ser 0");
        }
        if (l1 < 0)
        {
            throw new ArgumentException($"El lado: {l1} no puede ser un número negativo");
        }
        return l1;
    }


}
