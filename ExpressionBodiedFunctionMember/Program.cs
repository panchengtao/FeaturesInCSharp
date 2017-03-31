using System;

namespace ExpressionBodiedFunctionMember
{
    /// <summary>
    ///     特性：表达式方法体
    ///     说明：一句话的方法体可以直接写成箭头函数，而不再需要大括号
    /// </summary>
    internal class Program
    {
        private static string SayHello() => "Hello World";
        private static string JackSayHello() => $"Jack {SayHello()}";

        private static void Main(string[] args)
        {
            Console.WriteLine(SayHello());
            Console.WriteLine(JackSayHello());

            Console.ReadLine();
        }
    }
}