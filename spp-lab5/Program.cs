using System;
using System.Linq;
using System.Reflection;

namespace spp_lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Assembly.GetExecutingAssembly().Location;

            Assembly.LoadFrom(path).GetTypes()
                .Where(type => type.IsPublic)
                .OrderBy(type => type.FullName)
                .ToList()
                .ForEach(type => Console.WriteLine(type.FullName));
        }
    }
}

namespace A
{
    public class Hello
    {
    }

    class A
    {
    }

    public class B
    {
    }
}