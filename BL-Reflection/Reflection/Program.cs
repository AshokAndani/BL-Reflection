using System;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assembly assembly = Assembly.LoadFile(@"C:\Users\Ashokk\Desktop\BL\ReflectionSource\bin\Debug\netcoreapp3.1\ReflectionSource.dll");
            //// basic Reflection
            //Type type =assembly.GetType("ReflectionSource.Customer") ;

            //Console.WriteLine("FullName :" + type.FullName);

            //Console.WriteLine("Class Name : " + type.Name);
            //Console.WriteLine("Methods in Class ");

            //MethodInfo[] methods = type.GetMethods();
            //foreach (MethodInfo method in methods)
            //{
            //    Console.WriteLine(method.ReturnType.Name + "  " + method.Name);
            //}
            //Console.WriteLine("variables in class");
            //FieldInfo[] properties = type.GetFields();
            //foreach (FieldInfo property in properties)
            //{
            //    Console.WriteLine(property.FieldType + "  " + property.Name);
            //}
            //Console.WriteLine("Constructors in class");
            //ConstructorInfo[] constructors = type.GetConstructors();
            //foreach (ConstructorInfo constructor in constructors)
            //{
            //    Console.WriteLine(constructor.ToString());
            //}
            //Console.WriteLine("---------------end---------------");

            var result=MoodAnalyzeFactory.CreateMoodAalyze("Customer", "CustomerSomething");
        }
    }
}
