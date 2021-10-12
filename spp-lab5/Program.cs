using System;
using System.Linq;
using System.Reflection;

namespace spp_lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\developing\\projects\\С#\\Test\\Test\\bin\\Debug\\net5.0\\Test.dll";
            
            Assembly.LoadFrom(path).GetTypes()
                .Where(type => type.IsPublic)
                .OrderBy(type => type.FullName)
                .ToList()
                .ForEach(type => Console.WriteLine(type.FullName));
        }
    }
}