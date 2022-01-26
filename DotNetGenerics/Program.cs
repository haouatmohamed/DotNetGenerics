using System;

namespace DotNetGenerics
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //The problem with object GenericArrayList is typeSafety
            var list = new GenericArrayList(5);
            list.Add(new Employee("Med", 1000, Team.Development));
            list.Add(new Freelancer("Ht", 2000, Team.Operation)); // very bad
            list.Add(3); // yes, it possible ! 
        }
    }
}
