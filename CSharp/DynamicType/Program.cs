namespace DynamicType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 1; // "컴파일 시" a 변수는 int 타입으로 결정
            dynamic b = 2; // "런타임 중" 대입 값에 따라 타입 결정, 일종의 boxing이 일어남

            while (true)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "int":
                        b = 2;
                        break;
                    case "float":
                        b = 3.0f;
                        break;
                    case "string":
                        b = "안녕";
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"{b.GetType()}, b = {b}");
                

            }
            
        }
    }
}