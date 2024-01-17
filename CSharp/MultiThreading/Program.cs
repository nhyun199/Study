namespace MultiThreading
{
    internal class Program
    {
        static void StartMakingToast()
        {
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} : Making toast.....");
                Thread.Sleep(1000); // 1초 동안 해당 쓰레드 잠듦
                count++;
            }
            Console.WriteLine($"{Thread.CurrentThread.Name} : Made toast !!!");
        }

        static void Counting()
        {
            for (int i = 0; i < 100000; i++)
            {
                count++;
                //PPAF(ref count);
            }
        }

        static int PPAF(ref int a)
        {
            int tmp = a;
            a = tmp + 1;
            return tmp;
        }

        static void ThreadPoolCallback(object? threadContext)
        {
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Thread {(int)threadContext} started");
        }

        static int count;

        static void Main(string[] args)
        {
            //ThreadPool.SetMinThreads(1, 0);
            //ThreadPool.SetMaxThreads(4, 0);

            //for(int i = 0; i < 4; i++)
            //{
            //    ThreadPool.QueueUserWorkItem(ThreadPoolCallback, i);
            //}

            //ThreadPool.QueueUserWorkItem(ThreadPoolCallback); // WaitCallback 대리자

            //Thread thread1 = new Thread(Counting); // threadStart 라는 delegate를 parameter로 받음
            // => 가장 먼저 쌓고 싶은 함수를 구독해서 넣으면 됨
            // Parameterized => object type

            //thread1.Name = "Thread 1"; // 쓰레드에 이름을 지음
            //thread1.IsBackground = true;
            //thread1.Start(); // 해당 쓰레드 실행

            //Thread thread2 = new Thread(Counting);
            //thread2.Name = "Thread 2"; // 쓰레드에 이름을 지음
            //thread2.IsBackground = true;
            //thread2.Start(); // 해당 쓰레드 실행

            //thread1.Join();
            //thread2.Join();

            // Task : 쓰레드 풀의 쓰레드에 단일 작업을 할당하는 클래스
            Task t1 = new Task(StartMakingToast);
            t1.Start();
            t1.Wait();

            Task t2 = new Task(StartMakingToast);
            t2.Start();
            t2.Wait();

            List<Task> tasks = new List<Task>();
            for(int i = 0; i < 10; i++)
            {
                tasks.Add(Task.Factory.StartNew(StartMakingToast)); // Factory? 디자인 패턴 중 하나 StartNew => 만들자마자 바로 실행됨
            }

            Task.WaitAll(tasks.ToArray());
            Task<int> taskWithResult = new Task<int>(() =>
            {
                return new Random().Next(10);
            });

            taskWithResult.Start();
            taskWithResult.Wait();

            Console.WriteLine($"{taskWithResult.Result}");
            Console.WriteLine($"count : {count}");
            Console.ReadLine();

        }
    }
}