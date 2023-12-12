using static AllMethods.CV;
namespace TestApp
{
    internal class Program
    {
        static string separator = new('=', 20);
        static void Main(string[] args)
        {
            char[] input = { '0', '1', '3', '4', '5', '6', '7', '8', '9' };
            Write(input);
        }
        private static void Write(char[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(separator);
                var ans = GetNeighbors(item);
                Console.WriteLine($"for input {item}");
                foreach (char i in ans)
                {
                    Console.Write($"[ {i} ]");
                }
                Console.WriteLine();
            }
        }
    }
}
