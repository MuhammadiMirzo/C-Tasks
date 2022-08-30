public class Person 
{
    public int _age;
    public string Name { get; set; }
    public void Greet()
    {
        System.Console.WriteLine("Hello,");
    }
    public void SetAge(int age)
    {
        _age = age;
    }
}