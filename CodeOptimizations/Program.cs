using BenchmarkDotNet.Running;
using System;
using System.Diagnostics;
//concurrentBag vs List
namespace CodeOptimizations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var threadvsTasks = BenchmarkRunner.Run<ThreadVsTasks>();
            var stringBenchmark = BenchmarkRunner.Run<StringBuilderVsString>();
            var forVsForEach = BenchmarkRunner.Run<ForVsForEach>();
            var listVsArray = BenchmarkRunner.Run<ListVsArray>();
            var classVsStruct = BenchmarkRunner.Run<ClassVsStruct>();
            Console.ReadKey(true);
        }
    }
}
