using System.Linq;
namespace ExtensionMethod
{
    // 확장 메서드
    // 어떤 객체 참조를 대상으로 기능을 확장하려고 할 때 사용하는 함수
    // static 클래스 내에서 static 메서드를 만들고 기능을 확장해야하는 객체 참조를 파라미터로 받는다. => this 키워드를 추가해야함.

    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "hyun No"; // 문자열에 대해 기능을 확장? 확장 메서드는 다른 곳에 정의되어있음
                                     // source 데이터원본

            Console.WriteLine(name.WordCount());

            // Linq
            List<int> numbers = new List<int>()
            {
                1, 6, 7, 10, 2, 3, 22, 15, 12,
            };

            // C# 기본 쿼리문 
            IEnumerable<string> filtered =
                from number in numbers
                where number > 5
                orderby number descending
                select $"number : {number}";

            foreach (string number in filtered)
            {
                Console.WriteLine(number);
            }


            IEnumerable<string> filtered2 =
            numbers.Where(x => x > 5)
                   .OrderByDescending(x => x)
                   .Select(x => $"number : {x}");


            IEnumerable<int> numbersFiltered =
                numbers.Where(x => x > 5);

            foreach (int number in numbersFiltered)
            {
                Console.WriteLine(number);
            }

            

        }
    }
}