using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("Brown", 2);
        shapes.Add(s1);
        
        Rectangle s2 = new Rectangle ("Green", 7, 8);
        shapes.Add(s2);

        Circle s3 = new Circle ("Blue", 4);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
            Console.WriteLine("Thank you");
            Console.WriteLine("This is the final");
        }
        
    }  
       
}
