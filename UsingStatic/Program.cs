using static System.Math;
using static System.Console;

namespace UsingStatic
{
    /// <summary>
    ///     特性：静态类的方法的命名空间可以使用 using static
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            WriteLine(Log10(5) + PI);
        }
    }
}