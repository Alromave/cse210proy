public class Square : Shape
// define side
{
    private double _side;
    // to accept color and side
    public Square(string color, double side) : base (color)
    {
        _side = side;
    }
    public override double GetArea()
    // to define area
    {
        return _side * _side;
    }
}