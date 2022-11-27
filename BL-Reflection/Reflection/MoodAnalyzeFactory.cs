using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Reflection
{
    public class MoodAnalyzeFactory
    {
        public static object CreateMoodAalyze(string className,string constructorName)
        {
            string pattern = @"."+className+"$";
            Match match = Regex.Match(pattern, constructorName);
            if (match.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyzeObject = assembly.GetType("Reflection." + className);
                    return Activator.CreateInstance(moodAnalyzeObject);
                }
                catch (Exception)
                {
                    throw new MoodAnalyzeException(ExceptionType.NO_SUCH_CLASS, "there is no such class called "+className);
                }
            }
            else
            {
                throw new MoodAnalyzeException(ExceptionType.NO_SUCH_METHOD,"there is no such constructor called "+constructorName);
            }
        }
        public static object CreateMoodAnalyzeObectUsingParameterizedConstructor(string className,string constructorName,string message)
        {
            Type type = typeof(MoodAnalyze);

            if (type.Name.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string)});
                    object instance=constructor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyzeException(ExceptionType.NO_SUCH_METHOD, "no method as constructor");
                }
            }
            else
            {
                throw new MoodAnalyzeException(ExceptionType.NO_SUCH_CLASS, "no suuch class");
            }

        }
    }
}
