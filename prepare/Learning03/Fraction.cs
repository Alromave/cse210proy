using System;
using System.Security.Cryptography;
//create the class Fraction
class Fraction
// create attributes
{
    private int _top;
    private int _bottom;
  // create the constructors
    public Fraction()
    // Constructor that has no parameters that initializes the number to 1/1
    {
        _top = 1;
        _bottom = 1;

    }
    // constructor that has one parameter for the top and that initializes the denominators to 1.
    // So that if you pass in the number 5, the fraction would be initialized to 5/1
    public Fraction(int numberTop)
    {
      _top = numberTop;
      _bottom = 1;
    }
    // Constructor that has two parameter, one for the top and one for the bottom

    public Fraction(int top, int bottom)
    {
      _top = top;
      _bottom = bottom;
    }

//setp 5
public string GetFractionString()
{
  // step 6
  string text = $"{_top}/{_bottom}";
  return text;
}
public double GetDecimalValue()
{
  return (double)_top / (double)_bottom;
}



}
