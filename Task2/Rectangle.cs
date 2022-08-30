public class Rectangle : Shape
{
    double x;
    double y;
    public override double Area()
     {
        return x * y*2 ;
     }
     public override double Perimeter()
     {
        return 2 * (x+y);
     }
}