using BenchmarkDotNet.Attributes;
using System.Text;
//concurrentBag vs List
namespace CodeOptimizations
{
    public class StringBuilderVsString
    {
        [Benchmark]
        public void NormalStringRun()
        {
            string normalString = "Normal";
            
            for (int index = 0; index < 10000; index++)
            {
                normalString += index.ToString();
            }
        }
        [Benchmark]
        public void StringBuilderRun()
        {
            StringBuilder stringBuilder = new StringBuilder("Build");
            for (int index = 0; index < 10000; index++)
            {
                stringBuilder.Append(index.ToString());
            }
        }
    }
}
