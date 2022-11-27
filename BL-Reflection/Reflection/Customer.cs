using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Reflection
{
    internal class Customer
    {
        public int id;
        public string Name;
        public Customer()
        {

        }
        public Customer(string name)
        {
            Name = name;
        }
        public void PrintId()
        {
            Console.WriteLine(id);
        }
        public void PrintName()
        {
            Console.WriteLine(Name);
        }

    }
}
