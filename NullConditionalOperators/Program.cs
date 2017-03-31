using System;

namespace NullConditionalOperators
{
    /// <summary>
    ///     特性：空操作符 ?
    ///     说明：简单来说，就是判断对象是否为空的一种操作符。
    ///     当一个对象或者属性职为空时直接返回null, 就不再继续执行后面的代码（包含方法和数组）。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var p = new {FirstName = "wddpct"};
            Console.WriteLine(p?.FirstName ?? "wddmd");

            //User user = null;
            //user?.SayHello();
            //Console.Read();

            //Console.WriteLine(users?[1].Name); 
            //Console.WriteLine(listUsers?[1].Name); 

            Console.ReadKey();
        }
    }
}