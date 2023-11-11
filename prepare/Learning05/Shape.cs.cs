using System.Xml.Serialization;
// define color: add, get and set
public abstract class Shape
{
    private string _color;
    public Shape (string color)
    {
        _color = color;

    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

// get area
public abstract double GetArea();

}