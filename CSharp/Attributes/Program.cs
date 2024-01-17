
// Attribute (특성)
// Meta data 를 정의할 때 사용하는 클래스
// Meta? ~의 ~  ex) attribute class => class의 Metadata 를 정의함.
// 클래스, 구조체, 함수, 멤버필드, 프로퍼티 적용 가능

#define test
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Attributes
{
    [Obsolete("쓰지마")]
    internal class A
    {
        [Obsolete] // 더 이상 사용되지 않는다는 걸 의미하는 attribute
        public void OldMethod() => Console.WriteLine("This is old");
        public void NewMethod() => Console.WriteLine("This is new");
    }

    internal class B
    {
        // Conditional
        // #define 전처리기에서 정의된 문자열일때만 구현하는 특성

        // CallerMemberName
        // 호출자의 멤버의 이름을 자동으로 할당함

        [Conditional("test")]
        public static void Log([CallerMemberName] string callermember = default)
            => Console.WriteLine($"I'm B, called by {callermember}");
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.OldMethod();
            a.NewMethod();                        
            B.Log();

            LegoStore legostore = new LegoStore();
            legostore.PropertyChanged += (sender, args) =>
            {
                Console.WriteLine($"{args.PropertyName} of {sender} has changed..!");

                switch (args.PropertyName)
                {
                    case "CreatorTotal":
                        Console.WriteLine($"Luke는  달리기 시작했다.");
                        break;
                    case "StarwarsTotal":
                        {
                            if(legostore.StarwarsTotal < 3)
                                Console.WriteLine($"Luke : 제발");
                            else
                                Console.WriteLine($"Luke : 진짜 없네 ");
                        }
                        break;
                    case "CityTotal":
                        Console.WriteLine($"진짜 협찬받았냐?");
                        break;
                    default:
                        break;
                }
            };


            legostore.CreatorTotal = 1;
            legostore.StarwarsTotal = 5;
            legostore.CityTotal = 3;


            GoldUI ui = new GoldUI();

            while(true)
            {
                string input = Console.ReadLine();
                GoldViewModel.Instance.Value = Int32.Parse(input);

                Console.WriteLine(ui.text);
            }

        }
    }
}