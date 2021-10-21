using System;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;



namespace HomeWork03_Algorithms
{
    class Program
    {



        static void Main(string[] args)
        {
            Core core = new Core(); 
            core.CoreOutData();
            BenchmarkRunner.Run<Benchmark>();
            Console.ReadLine();
        }

    }




}

