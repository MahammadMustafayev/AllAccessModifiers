using Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessNamespace.Models
{
    class Teacher:Person
    {
        
        public void Məllim()
        {
            Name = "Anar";
            SurName = "Qandayev";
            Age = 24;
            // weight yazmaq olmur cunki (private protected) ozunde ve miras aldiqlarinda isleyir basqa projectde (private) olur.
            Teacher teacher = new Teacher();
            //Person p = new Person();
        }
        public Teacher()
        {
            Name = "Anar";
            SurName = "Qandayev";
        }
    }
}
