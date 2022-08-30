public class Student : Person
{
    public void Study()
    {
        System.Console.WriteLine("I am studying");
    }
    public void ShowAge()
    {
        System.Console.WriteLine(_age);
    }
}