using System.Diagnostics; // 성능 진단
using System.Linq;        // Linq(Language-intergrated Query)
                          // 다양한 자료 구조들에 대한 탐색/취합/추출/반복 등에 대한 기능을 제공하는 namespace
namespace SortAlgos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = //{ 1, 4, 3, 3, 9, 8, 7, 2, 5, 0 };
                Enumerable.Repeat(0, 10000000)
                          .Select(x => random.Next(0, 1000))
                          .ToArray();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ArraySort.BubbleSort(arr); // 0초 = 1만개 250ms
            //ArraySort.SelectionSort(arr); // 1만개 100ms
            //ArraySort.InsertionSort(arr); // 1만개 60ms
            //ArraySort.RecursiveMergeSort(arr); 1000만개 2000ms(중복이 많을 때) 1000만개 2500ms(중복이 적을 때)
            //ArraySort.MergeSort(arr); // 1000만개 2000ms(중복이 많을 때) 1000만개 2400ms(중복이 적을 때)
            stopwatch.Stop();
            Console.WriteLine($"ElapsedTime: {stopwatch.ElapsedMilliseconds}");
            
            //Console.Write("{");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //  Console.Write($"{arr[i]}, ");
            //}
            //Console.Write("}");
        }
    }
}