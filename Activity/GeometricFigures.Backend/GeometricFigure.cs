namespace GeometricFigures.Backend;

public abstract class GeometricFigure 
{
    //Properties
    public string Name { get; set; } = null!; 
    //Methods
    public override string ToString() => $"{Name,-12}" +
        $"\t=>Area.....:{GetArea(),15:N5}" +
        $"\tPerimiter.....:{GetPerimiter(),15:N5}";
    public abstract double GetArea();
    public abstract double GetPerimiter();

}