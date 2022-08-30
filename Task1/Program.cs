
var list = new List<Person>();

for (int i = 1; i <=3; i++)
{
  var person = new Person(); 
  person.Name = Console.ReadLine();
  list.Add(person);
}

list.ForEach(p=>System.Console.WriteLine("My name is "+ p.ToString()));

foreach (var item in list )
{
   System.Console.WriteLine("My name is " + item.ToString()); 
}

Console.ReadKey();



