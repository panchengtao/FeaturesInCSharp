using System;
using System.Threading.Tasks;

namespace StringInterpolation
{
    /// <summary>
    ///     特性：字符串插值
    ///     说明：简略代码拼接长度，不仅可以插入字符串，还可以插入代码方法
    /// </summary>
    internal class Program
    {
        private string SayHello()
        {
            return "Hello!";
        }

        private async static Task<string> GetDiscount()
        {
            return "2000";
        }

        private static void Main(string[] args)
        {
            var p = new {FirstName = "Jack", LastName = "Wang", Age = 100};
            var results = $"First Name: {p.FirstName} LastName: {p.LastName} Age: {p.Age}";
            Console.WriteLine(results);

            Console.WriteLine($"Jack is saying {new Program().SayHello()}");

            var info = $"Your discount is { GetDiscount().Result}";
            Console.WriteLine(info);

            Console.ReadKey();
        }
    }
}