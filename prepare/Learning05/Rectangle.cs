public class Rectangle : Shape
{
    // to define sides
    private double _length;
    private double _width;
    // get sides and color
    public Rectangle ( string color, double length, double width) : base (color)
    {
        _length = length;
        _width =  width;

// area
    }
    public override double GetArea()
    {
        return _length * _width;
    }
    

    
}
