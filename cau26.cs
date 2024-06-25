﻿using System;
using System.Text;

abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract override string ToString();
}

class Student : Person
{
    public string Major { get; set; }

    public Student(string name, int age, string major) : base(name, age)
    {
        Major = major;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Major: {Major}";
    }
}

class Program
{
    static void Main(string[] args)
    {Console.OutputEncoding=Encoding.UTF8;
        Student student = new Student("Nguyễn Tiến Dũng", 20, "CNTT&TT");
        Console.WriteLine(student.ToString());
    }
}
