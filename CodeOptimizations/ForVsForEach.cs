using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
//concurrentBag vs List
namespace CodeOptimizations
{
    public class ForVsForEach
    {
        List<int> list = new List<int>();

        [Benchmark]
        public void ForRun()
        {
            for (int index = 0; index < 10000; index++)
            {
                list.Add(index);
            }
        }
        [Benchmark]
        public void ForEachRun()
        {
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
