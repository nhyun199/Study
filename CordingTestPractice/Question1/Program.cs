namespace Question1
{
    public class Program
    {   
        static void main()
        {
            string[] inputs = new string[] { "000", "1110", "01", "001", "110", "11" };
            int[] result = Solution(inputs);
            // 0, 1, 1, 3, 2, 5 이 나와야함

            Console.Write("[");
            for(int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]},");
            }
            Console.Write("]");
        }

        static int[] Solution(string[] args)
        {
            
            
        }
    }
}