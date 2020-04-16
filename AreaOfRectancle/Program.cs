using System;

namespace AreaOfRectancle
{
    class Program
    {
        static void Main(string[] args)
        {
    Rectangular rectangle = new Rectangular();
    rectangle.Length = 15.0;
    rectangle.Width = 13.5;
        Console.WriteLine(rectangle.Perimeter);
        Console.WriteLine(rectangle.Area);

          try
             {
                 rectangle.Length = 22.0;
                rectangle.Width = 2.5;

             }
             catch (ArgumentOutOfRangeException e)
             {
                 Console.WriteLine(e.ParamName);
             }
    }
    
}
}