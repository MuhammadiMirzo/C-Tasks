﻿System.Console.Write("Student1 : ");
string name1 = Console.ReadLine();
System.Console.Write("Student2 : ");
string name2 = Console.ReadLine();
System.Console.Write("Teacher : ");
string name3 = Console.ReadLine();
var student1 = new Student(name1);
var student2 = new Student(name2);
var teacher = new Teacher(name3);
 student1.Study(); 
 student2.Study(); 
 teacher.Explain(); 