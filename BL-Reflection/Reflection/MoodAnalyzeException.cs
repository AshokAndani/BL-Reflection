using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class MoodAnalyzeException : Exception
    {
      
        public MoodAnalyzeException(ExceptionType exceptionType, string exceptionName):base(exceptionName)
        {
            
        }
    }
    public enum ExceptionType
    {
        NO_SUCH_METHOD,
        NO_SUCH_CLASS
    }
   
    public class Parent 
    {
        public Parent()
        {

        }
        public Parent(string name)
        {
        }
    }
    public class Child : Parent
    {
        public Child(string name)
        {
           
            Console.WriteLine("Child Class Constructor called");
        }
    }
    
}
