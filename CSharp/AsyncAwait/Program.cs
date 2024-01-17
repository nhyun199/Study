using System.Net.Http;
using System.Runtime.InteropServices;

namespace AsyncAwait
{
    internal class Program
    {
        static async Task Main(string[] args) 
        {
            //Task<bool> uselessTask = SayHi5Times();           
            //uselessTask.Wait();
            //Console.WriteLine($"{uselessTask.Result}");
            
            bool result = await SayHi5Times(); // 비동기 로직을 실행한다는 것을 명시 async, 반드시 Task를 반환해야함 
            Console.WriteLine(result);
            string url = "https://jsonplaceholder.typicode.com/todos/3";
            string content = await RequestHttpContentAsync(url);
            Console.WriteLine(content);
        }

        static async Task<string> RequestHttpContentAsync(string url)
        {
            using(HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                string content = await response.Content.ReadAsStringAsync();
                return content;
            }
        } 


        static async Task<bool> Dummy()
        {
            return await SayHi5Times();
        }

        static Task<bool> SayHi5Times()
        {
            return
            Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Hi {i} times");
                    Thread.Sleep(500);
                }
                return true;
            });
        }
    }
}