using System;

namespace AutoPropertyInitializer
{
    /// <summary>
    ///     特性：自动实现的初始化器
    ///     说明：使用 C# 6 自动实现的带有初始值的属性可以不用编写构造器就能被初始化
    /// </summary>
    public class AutoPropertyInCsharp6
    {
        public long PostId { get; set; } = 1;

        public string PostName { get; protected set; } = "Post 1";

        public string PostTitle { get;} = string.Empty;
    }

    class Program
    {
        static void Main(string[] args)
        {
            AutoPropertyInCsharp6 feature = new AutoPropertyInCsharp6();
            Console.WriteLine(feature.PostId+feature.PostName+feature.PostTitle);

            Console.ReadKey();
        }
    }
}