namespace GeometricFigures.Backend;

public abstract class GeometricFigures 
{
    //Properties
    public string Name { get; set; } = null!; 
    //Methods
    public override string ToString()
    {
        return $"{Name}:Area:{GetArea()} Perimetro:{GetPerimiter()}";
    }
    public abstract double GetArea();
    public abstract double GetPerimiter();

}