using System;
using System.Collections.Generic;

class Student {
    public string Name { get; set; }
    public double Grade { get; set; }
}

class Program {
    static void Main() {
        List<Student> students = new List<Student>();
        students.Add(new Student { Name = "Majid", Grade = 85.5 });
        
        Console.WriteLine("Student Record Processed Successfully.");
        foreach(var s in students) {
            Console.WriteLine($"Name: {s.Name}, Score: {s.Grade}");
        }
    }
}
