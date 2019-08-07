using BenchmarkDotNet.Attributes;
//concurrentBag vs List
namespace CodeOptimizations
{
    public class ClassVsStruct
    {
        [Benchmark]
        public void ClassRun()
        {
            ClassForBenchMark classForBenchMark;
            for (int index = 0; index < 1000; index++)
            {
                classForBenchMark = new ClassForBenchMark { integer = 6, floater=9 };
            }
        }
        [Benchmark]
        public void StructRun()
        {
            StructForBenchMark structForBenchMark;
            for (int index = 0; index < 1000; index++)
            {
                 structForBenchMark = new StructForBenchMark { integer = 6, floater = 9 };
            }
        }
    }
}
