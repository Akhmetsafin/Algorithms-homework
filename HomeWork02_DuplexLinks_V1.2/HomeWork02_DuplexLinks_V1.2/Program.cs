using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ConsoleApp2
{
    public class Program
    {
        [Benchmark]
        public void NotePad()
        {
            string path = @"D:\HomeworkGB\Algorithms homework\HomeWork02_DuplexLinks_V1.2\1.las";
            var sr = new StreamReader(path, Encoding.Default);
            List<int> numbers = new List<int>();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Length == 0) continue;
                for (int i = 0; i < 80; i += 10)
                    numbers.Add(Convert.ToInt32(line.Substring(i, 10)));
            }
            sr.Close();
        }
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Program>();
        }

    }
}