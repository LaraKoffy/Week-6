using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr1
{
    public class Person
    {
     
        private string _name;
        private int _age;

     
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

       
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0) 
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be negative.");
                }
            }
        }
    }
}
