using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Student:Person
    {
        public void Telebe()
        {
            Name = "Mehemmed";
            SurName = "Mustafayev";
            Age = 20;
            Weight = 90;
            //(fin) yazmaq olmur cunki yalnizca yazildiqi yerde yazmaq olur.
            //Person p = new Person();
            Student student = new Student();
        }
    }
}
