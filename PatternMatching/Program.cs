using System;

namespace PatternMatching
{
    /// <summary>
    ///     特性：模式匹配
    ///     说明：C# 7.0引入了模式的概念，抽象的讲，模式是语法元素，
    ///     能用来测试一个数据是否具有某种“形”，并且在它被使用的时候从中提取信息。
    ///     C# 7.0中的模式示例：
    ///     1. C形式的常量模式(C是C#中的常量表达式)，我们可以验证输入是否等于C
    ///     2. TX形式的类型模式(T是一种类型，X 是一个标识符)。
    ///     3. Var x形式的Var模式(x是一个标识符)。
    ///     在C# 7.0中，我们改进了两种已经存在的模式语法设计：
    ///     1. is表达式的右值也可以是模式，而不仅仅只能是一种类型。
    ///     2. switch中的case分支，也可以匹配模式，而不仅仅是常量了。
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            PrintStars(10);
            Switch(123);
            Switch("123");

            Console.ReadKey();
        }

        /// <summary>
        ///     常量匹配+类型匹配
        /// </summary>
        /// <param name="o"></param>
        public static void PrintStars(object o)
        {
            if (o is null)
                return;
            if (!(o is int i))
                return;
            Console.WriteLine(new string('*', i));
        }

        /// <summary>
        ///     带模式的 Switch 语句
        /// </summary>
        /// <param name="o"></param>
        public static void Switch(object o)
        {
            if (o != null)
                switch (o)
                {
                    case int i:
                        Console.WriteLine($"int type: {i}");
                        break;
                    case string s:
                        Console.WriteLine($"string type: {s}");
                        break;
                }
            else
                Console.WriteLine("the 'o' is null!");
        }
    }
}