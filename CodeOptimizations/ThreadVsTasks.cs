using BenchmarkDotNet.Attributes;
using System.Threading;
using System.Threading.Tasks;
//concurrentBag vs List
namespace CodeOptimizations
{
    public class ThreadVsTasks
    {
        [Benchmark]
        public void TaskRun()
        {
            Task.Run(async () =>
            {
                await Task.WhenAll(TaskSaveData(), TaskPrintData());
            }).GetAwaiter().GetResult();
        }
        [Benchmark]
        public void ThreadRun()
        {
            Thread saveData = new Thread(ThreadSaveData);
            Thread printData = new Thread(ThreadPrintData);
            saveData.Start();
            printData.Start();

        }
        public async Task TaskSaveData()
        {
            await Task.Delay(2000);
        }
        public async  Task TaskPrintData()
        {
            await Task.Delay(1000);
        }
        public void ThreadSaveData()
        {
            Thread.Sleep(2000);
        }
        public void ThreadPrintData()
        {
            Thread.Sleep(1000);
        }
    }
}
