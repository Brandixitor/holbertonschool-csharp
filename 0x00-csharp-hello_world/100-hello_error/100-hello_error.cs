using System;
using System.IO;
using System.Reflection;

namespace _100_hello_error
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Error.WriteLine("and that piece of art is useful - Dora Korpar, 2015-10-19");
            Environment.ExitCode = 1;
            Console.Error.Close();
        }
    }
}