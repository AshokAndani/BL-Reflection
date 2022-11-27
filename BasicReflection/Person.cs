using System;
using System.Collections.Generic;
using System.Text;

namespace BasicReflection
{
    public class Person
    {
        public Person(int age,string name)
        {

        }
        public Person()
        {
            Console.WriteLine("Object got Created");
        }
        public string Name;
        public int Age;
        public int GetAge()
        {
            return Age;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetAge(int age)
        {
            this.Age = age;
        }
    }
}
