using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Person
    {
        public string Name { get; set; }
        protected string SurName { get; set; }
        protected internal int Age { get; set; }
        private protected int Weight { get; set; }
        private string Fin { get; set; }
        
        public void Info()
        {
            Person person = new Person();
            person.Fin = "56UKED81";

        }
        
        
    }
}
