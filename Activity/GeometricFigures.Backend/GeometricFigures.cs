namespace GeometricFigures.Backend;

public abstract class GeometricFigures 
{
    //Properties
    public string Name { get; set; } = null!; 
    //Methods
    public override string ToString()
    {
        return $"{Name}\t=> Area.....:{GetArea(),15:N5} \tPerimiter.....:{GetPerimiter(),15:N5}";
    }
    public abstract double GetArea();
    public abstract double GetPerimiter();

}