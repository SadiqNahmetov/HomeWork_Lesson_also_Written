using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Encapsulation
{
    class Teacher:Person
    {
        public decimal salary;

        public Teacher(int number,string name, int age):base(number, name, number)
        {
            
        }
    }
    
      
}

