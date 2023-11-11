using System.Security.Cryptography;

public class Circle : Shape
{
    // get radius
    private double _radius;
    // to define radius and color
    public Circle (string color, double radius): base (color)
    {
        _radius = radius;
    }
    // to define area 
    public override double GetArea()

    {
        return _radius * _radius * Math.PI;
        
    }
}