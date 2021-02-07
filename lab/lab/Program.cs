using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public String name;
    public int id;
    public String depertment;
    public float cgpa;

    public void ShowDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID " + id);
        Console.WriteLine("Depertment" + depertment);
        Console.WriteLine("CGPA " + cgpa);