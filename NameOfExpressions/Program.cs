using System;
using System.Threading.Tasks;

namespace NameOfExpressions
{
    /// <summary>
    ///     特性：nameof 表达式
    ///     说明：你可以让编译器生成字符串表示的符号。
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            var user = new
            {
                Name = "wddpct"
            };

            Console.WriteLine(nameof(user.Name)); //  output: Name
            Console.WriteLine(nameof(System.Linq)); // output: Linq
            Console.WriteLine(nameof(Task)); // output: Task
            Console.ReadLine();
        }
    }
}