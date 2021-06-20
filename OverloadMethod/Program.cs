using System;

namespace OverloadMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Tiago";
            var middleName = "Aguiar";
            var lastName = "Moreira";

            Console.WriteLine(People.FullName(firstName, middleName));
            Console.WriteLine(People.FullName(firstName, middleName, lastName));
        }
    }
}