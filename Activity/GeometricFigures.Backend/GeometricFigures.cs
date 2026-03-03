namespace GeometricFigures.Backend;

public abstract class GeometricFigures 
{
    public int Name       
    {   
        get;    
        set;    
    }

    public override string ToString()
    {
        return base.ToString();
    }
    public abstract double GetArea()
    { 
        
    }

    public abstract double GetPerimiter()
    {

    }

}