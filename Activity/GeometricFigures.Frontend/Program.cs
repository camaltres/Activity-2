using GeometricFigures.Backend;

var circle = new Circle(name: nameof(Circle), r: 5);
var square = new Square(name: nameof(Square), a: 10);
var rhombus = new Rhombus(name: nameof(Rhombus), a: 5, d1: 7, d2: 10);
var kite = new Kite(name: nameof(Kite), a: 7, b: 8, d1: 6, d2: 5);

Console.WriteLine(circle);
Console.WriteLine(square);
Console.WriteLine(rhombus);
Console.WriteLine(kite);