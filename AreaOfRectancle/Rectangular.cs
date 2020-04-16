using System;
namespace AreaOfRectancle
{
    public class Rectangular
{
    private double length = 1;
    private double width = 1;

   
    
    public double Length
    {
        get { return length; }
        set
        {
            if ((value <= 0.0) || (value >= 20.0))
                throw new ArgumentOutOfRangeException("Length must be greater than 0.0 and less than 20.0");
            length = value;
        }
    }

    
    public double Width
    {
        get { return width; }
        set
        {
            if ((value <= 0.0) || (value >= 20.0))
                throw new ArgumentOutOfRangeException("Width must be greater than 0.0 and less than 20.0");
            width = value;
        }
    }

      public double Perimeter
    {
        get { return (2.0 * Length) + (2.0 * Width); }
    }

    public double Area
    {
        get { return Length * Width; }
    }

}
}