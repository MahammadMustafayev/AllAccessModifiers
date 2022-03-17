using System;
using AccessNamespace.Models;
using Library;


namespace AccessNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
             Person p = new Person();
            Teacher teacher = new Teacher();
            Console.WriteLine(teacher.Name);//(teacher.Name) public olduqu ucun (Program.cs) yazmaq olur ,basqa halda xeta verir.
        }
    }
}
