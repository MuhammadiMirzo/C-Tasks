
public class Shape 
{
    public Location Location { get; set; }
    public override string ToString()
    {
        return "this is shape";
    }
    public virtual double Area()
    {
        return 0;
    }
    public virtual double Perimeter()
    {
        return 0;
    }


}