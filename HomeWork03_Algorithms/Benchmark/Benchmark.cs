using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using HomeWork03_Algorithms;


namespace Benchmark
{
    public class Benchmark

    {
        public  Core myCore = new Core();
       

        Point A = new Point(1.2, 2.3);
        Point B = new Point(11, 22);
        Tochka C = new Tochka(1.2, 2.3);
        Tochka D= new Tochka(11, 22);
        
        [Benchmark(Description = "Test")]
        public void CoreClas()
        {
            var result = myCore.RunClass(A,B);
        }
        [Benchmark(Description = "Test2")]
        public void CoreStruct()
        {
            var result = myCore.RunStruct(C, D);
        }
    }
}
