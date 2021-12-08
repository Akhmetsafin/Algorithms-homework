using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.IO;

namespace AlgorithmsHoumeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Simple_number simple_Number = new Simple_number();
            simple_Number.Core();

        }
        
    }
}
