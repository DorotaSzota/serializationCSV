using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace serializacja1
{
    
     internal class Person 
    {
        private string name;
        private int age;
        private string email;

         public string Name { get { return name; } set { name = value; } }
         public int Age { get { return age; } set { age = value; } }
         public string Email { get { return email; } set { email = value; } }

        public Person(){}
        public Person(string name, int age, string email)
        {this.name = name; this.age = age; this.email = email;}

        public override string ToString() => $"{this.Name},{this.Age},{this.Email}";

    }
}
