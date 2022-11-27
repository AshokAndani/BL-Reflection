using System;
using System.Reflection;

namespace BasicReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var assembly= Assembly.GetExecutingAssembly();
            var assemblyName= assembly.GetName().Name;
            Console.WriteLine("current Executing assembly Name is: "+assemblyName);
            var personType = assembly.GetType("BasicReflection.Person");
            FieldInfo[] fields=personType.GetFields();
            MethodInfo[] methodInfos = personType.GetMethods();
            ConstructorInfo[] constructorInfos = personType.GetConstructors();
            Console.WriteLine("Methods defined in Person Class:");
            foreach (MethodInfo methodInfo in methodInfos)
            {
                Console.WriteLine(methodInfo.Name);
                var param= methodInfo.GetParameters();
                foreach (var paramInfo in param)
                {
                    Console.Write(paramInfo.Name+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("fields defined in Person Class:");
            foreach(FieldInfo field in fields)
            {
                Console.WriteLine("FieldName: "+field.Name+" DataType: "+field.FieldType);
            }
            Console.WriteLine("constructors defined in Person class:");
            foreach(var constructor in constructorInfos)
            {
                Console.WriteLine(constructor.Name);
                var param= constructor.GetParameters();
                foreach(ParameterInfo paramInfo in param)
                {
                    Console.Write(paramInfo.Name+" ");
                }
                Console.WriteLine();
            }
            var obj=(Person)Activator.CreateInstance(personType);
        }
    }
}
