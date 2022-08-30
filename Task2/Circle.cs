public class Circle : Shape
{
     double radius { get; set; }
     double pi = 3.14;
     public override double Area()
     {
        return radius * radius ;
     }
     public override double Perimeter()
     {
        return 2 * pi * radius;
     }
}