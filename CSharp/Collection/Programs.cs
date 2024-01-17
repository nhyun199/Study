using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    #region ItemId & Slotdata
    enum ItemID
    {
        RedPotin = 20,
        BluePotin = 21,
    }

    class Slotdata : IComparable<Slotdata>
    {
        public bool isEmpty => id == 0 && num == 0;
        public int id;
        public int num;

        public Slotdata(int id, int num)
        {
            this.id = id;
            this.num = num;
        }

        public int CompareTo(Slotdata? other)   // IComparable의 멤버이며, 직접 구현해야 사용할 수 있음.
        {
            return this.id == other?.id && this.num == other.num ? 0 : -1;
        }

    }
    #endregion
   
    class Programs
    {        

        static void Main(string[] args)
        {

            #region DynamicArray
              

            DynamicArray1 invenObj = new DynamicArray1();

            for (int i = 0; i < 10;  i++)
            {
                invenObj.ADD(new Slotdata(0, 0));
            }

            invenObj[0] = new Slotdata((int)ItemID.RedPotin, 40);
            invenObj[1] = new Slotdata((int)ItemID.BluePotin, 99);
            invenObj[2] = new Slotdata((int)ItemID.BluePotin, 40);

            Console.WriteLine("-인벤토리 정보-");
            for (int i = 0;i < invenObj.Count; i++)
            {
                Console.WriteLine($"슬롯{i+1} : [{(ItemID)((Slotdata)invenObj[i]).id}], [{((Slotdata)invenObj[i]).num}]");
            }

            int Addindex1 = invenObj.FindIndex(Slotdata => ((Slotdata)Slotdata).isEmpty ||
                                                         (((Slotdata)Slotdata).id == (int)ItemID.BluePotin && 
                                                         ((Slotdata)Slotdata).num <= 99-5));

            int AddPotin1 = ((Slotdata)invenObj[Addindex1]).num + 5;

            Slotdata newslotdata1 = new Slotdata((int)ItemID.BluePotin, AddPotin1);
            invenObj[Addindex1] = newslotdata1;

            Console.WriteLine();
            Console.WriteLine("-수정된 인벤토리 정보-");
            for (int i = 0; i < invenObj.Count; i++)
            {
                Console.WriteLine($"슬롯{i + 1} : [{(ItemID)((Slotdata)invenObj[i]).id}], [{((Slotdata)invenObj[i]).num}]");
            }
            Console.WriteLine();
            Console.WriteLine($"실제 사용된 영역 : {invenObj.Count}");
            Console.WriteLine($"전체 공간 : {invenObj.Capacivity}");
            Console.WriteLine();




            DynamicArray2<Slotdata> invenT = new DynamicArray2<Slotdata>();
            IEnumerable<Slotdata> enumerable = invenT;
            // 참조타입이 멤버에 접근할 때
            // 주소로부터 데이터를 명시된 타입크기만큼 읽어서 접근

            for (int i = 0; i < 10;  i++)
            {
                invenT.ADD(new Slotdata(0,0));
            }

            invenT[0] = new Slotdata((int)ItemID.RedPotin, 40);
            invenT[1] = new Slotdata((int)ItemID.BluePotin, 99);
            invenT[2] = new Slotdata((int)ItemID.BluePotin, 40);

            Console.WriteLine("-인벤토리 정보(Generic)-");
            for (int i = 0;i < invenT.Count;i++)
            {
                Console.WriteLine($"슬롯{i+1} : [{(ItemID)invenT[i].id}], [{invenT[i].num}]");
            }

            int Addindex2 = invenT.Findindex(Slotdata => Slotdata.isEmpty || 
                                            (Slotdata.id == (int)ItemID.BluePotin && 
                                             Slotdata.num <= 99-5));
            int AddPotin2 = invenT[Addindex2].num + 5;

            Slotdata newslotdata2 = new Slotdata((int)ItemID.BluePotin, AddPotin2);
            invenT[Addindex2] = newslotdata2;

            Console.WriteLine();
            Console.WriteLine("-수정된 인벤토리 정보(Generic)-");
            for (int i = 0; i < invenT.Count; i++)
            {
                Console.WriteLine($"슬롯{i + 1} : [{(ItemID)invenT[i].id}], [{invenT[i].num}]");
            }
            Console.WriteLine();
            Console.WriteLine($"실제 사용된 영역 : {invenT.Count}");
            Console.WriteLine($"전체 공간 : {invenT.Capacivity}");
            Console.WriteLine();

            // using 구문 : iDisposable 객체의 Dipose() 호출을 보장하는 구문
            // using (IEnumerator<Slotdata> enumerator = inven1.GetEnumerator())
            using (IEnumerator<Slotdata> enumerator = invenT.GetEnumerator())
            {
                // foreach문 c#의 대부분 자료구조는 가능.
                while (enumerator.MoveNext())
                {
                    Console.WriteLine($"[{(ItemID)enumerator.Current.id}], [{enumerator.Current.num}]");
                    // Current 는 수정불가능하다 => get이기 때문에
                }
                enumerator.Reset(); // <= 사용하지 않으면 재사용할 수 없음, 사용하지 않고 while문을 다시 사용해도 출력되지 않음.
                                    // 책이 덮여있기 때문?
                // enumerator.Dispose(); // 메모리(heap)의 누수가 일어날 수 있기 때문에 반드시 사용해야함

                foreach (var item in invenT) // 읽기전용, 한번에 하나의 콜렉션(자료구조)만 순회가능.
                {
                    Console.WriteLine((ItemID)item.id);
                }
                
            }
            Console.WriteLine("--------------------------End Dynamic Array--------------------------");
            Console.WriteLine();

            #endregion

            #region Queue
            // 줄을 서서 기다리는 모든 로직 : 대기열 선입선출
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(3); // En 삽입
            if (queue.Peek() > 0) // Peek 탐색 중간에 있는 값을 탐색 할 수 없음, 탐색해야 한다면 Queue를 사용하면 안됨            
                queue.Dequeue(); // Dequeue 삭제            

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }    
            #endregion

            #region Stack
            Stack<int> stack = new Stack<int>(); // 하노이탑 후입선출
            stack.Push(3); // Push 삽입
            if (stack.Peek() > 0) // Peek 탐색
                stack.Pop();

            #endregion

            #region Linked List
            Console.WriteLine("--------------------------Start Linked List--------------------------");
            
            
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(30);
            list.AddFirst(40);
            list.AddFirst(50);
            
            //Console.WriteLine(list.Find(x => x > 0).Value);

            IEnumerator<int> enumerator2 = list.GetEnumerator();

            while(enumerator2.MoveNext())
            {
                Console.WriteLine(enumerator2.Current);
            }



            Console.WriteLine("--------------------------End Linked List--------------------------");
            #endregion

            #region HashTable
            Console.WriteLine("--------------------------Start HashTable--------------------------");
            
            //MyHashTable<string, int> my = new MyHashTable<string, int>();
            //my.Add("Hyun", 90);
            //my.Add("Hyun2", 100);
            

            //foreach(var item in my)
            //{
            //    Console.WriteLine(item.Key);
            //}





            // c# 제공 Hashtable
            Hashtable hashtable = new Hashtable();
            hashtable.Add("철수", 90.0f);

            Dictionary<string, float> dictionary = new Dictionary<string, float>();
            dictionary.Add("hyun", 90.0f);

            foreach(var item in dictionary)
            {
                Console.WriteLine($"Key = {item.Key}");
                Console.WriteLine($"Value = {item.Value}");
            }
            
            Console.WriteLine("--------------------------End HashTable--------------------------");
            #endregion

            #region Yield
            IEnumerator routine = GetMakingToastRoutine();
            IEnumerator routine2 = GetMakingToastRoutine2();
            IEnumerable routine3 = NumberEnumerationRoutine();

            while(routine.MoveNext())
            {
                Console.WriteLine(routine.Current);
            }

            Console.WriteLine("-------use yield------");
            while (routine2.MoveNext())
            {
                Console.WriteLine(routine2.Current);
            }

            foreach(var item in routine3)
            {
                Console.WriteLine(item);
            }    
            // foreach 구문은 IEnumerable 


        }

        static IEnumerator GetMakingToastRoutine()
        {
            return new MakingToastRoutine();
        }

        static IEnumerator GetMakingToastRoutine2()
        {
            // yield 키워드
            // Enumerator 객체 정의의 간소화 구문
            // yield return / MoveNext 할 때마다 바뀔 값 작성

            yield return "Induction On";
            yield return "Pan Ready";
            yield return "Put butter";
            yield return "Put bread in Pan";
            yield return "Wait until bread toasted";
            yield return "Put am on bread";
            yield return "Induction Off";
            yield return "Toast is ready";

            
        }

        static IEnumerable NumberEnumerationRoutine()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }


        struct MakingToastRoutine : IEnumerator
        {
            public object Current => _routine[_step];
            private string[] _routine =
            {
                "Induction On",
                "Pan Ready",
                "Put butter",
                "Put bread in Pan",
                "Wait until bread toasted",
                "Put am on bread",
                "Induction Off",
                "Toast is ready"
            };
            private int _step = -1;

            public MakingToastRoutine()
            {
            }

            public bool MoveNext()
            {
                if (_step >= _routine.Length)
                    return false;

                _step++;
                return _step < _routine.Length;
                
            }

            public void Reset()
            {
                _step = -1;
            }
            #endregion
            
        }



        bool isBiggerThan0(int x)   // predicate<int>  
        {
            return x > 0;
        }
        
    }

    
}