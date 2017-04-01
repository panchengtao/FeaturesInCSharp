using System;
using static  System.Console;

namespace OutVariables
{
    /// <summary>
    ///     特性：out 输出变量
    ///     说明：在C#7.0版本中添加了out变量，可以在给一个函数传入参数的时候再去定义变量的能力。
    ///     需要注意的是，函数参数也需要有out关键字修饰。
    ///     除了可以在下文中引用这个变量以外，另一个常见的用法是c#中的Try…模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string input = "123";

            if (int.TryParse(input, out var result))
                WriteLine(result);
            else
                WriteLine("Could not parse input");

            SaySomething(out string something);
            WriteLine("What I say is {0}",something);

            ReadKey();
        }

        static void SaySomething(out string something)
        {
            something = "Hello!";
            WriteLine(something);
        }
    }
}