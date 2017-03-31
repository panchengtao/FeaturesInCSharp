using System;
using System.Collections.Generic;

namespace IndexInitializer
{
    /// <summary>
    ///     特性：字典初始化器
    ///     说明：像数组里使用方括号的方式那样定义一个字典初始化器，
    ///     该例中也结合了自动属性初始化器的使用
    /// </summary>
    public class DictionaryInitializerInCSharp6
    {
        public Dictionary<string, string> Users { get; } = new Dictionary<string, string>
        {
            ["users"] = "Venkat Baggu Blog",
            ["Features"] = "Whats new in C# 6"
        };
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var feature = new DictionaryInitializerInCSharp6();

            foreach (var item in feature.Users)
                Console.WriteLine(item.Key + item.Value);
        }
    }
}