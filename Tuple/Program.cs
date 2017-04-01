using System;

namespace Tuple
{
    /// <summary>
    ///     特性：元组
    ///     说明：这是一个从方法中返回多个值的常见模式。
    ///     注意：需要安装 System.ValueTuple nuget包
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            var result1 = _multipleStringResult();
            Console.WriteLine(result1.Item1 + result1.Item2 + result1.Item3);

            var result2 = _multipleStringResult();
            Console.WriteLine(result2.Item1 + result2.Item2 + result2.Item3);

            var p = new Person("Althea", "Goodwin");
            var (first, last) = p;
            Console.WriteLine(first + last);
            //p.Deconstruct(out string first,out string lastName);
            //Console.WriteLine(first+lastName);

            Console.ReadKey();
        }

        private static (string x,string y,string z) _multipleStringResult()
        {
            return ("x", "y", "z");
        }

        public class Person
        {
            public Person(string first, string last)
            {
                FirstName = first;
                LastName = last;
            }

            public string FirstName { get; }
            public string LastName { get; }

            /// <summary>
            ///     定义指定名称的 Deconstruct 方法，用于结构
            /// </summary>
            /// <param name="firstName"></param>
            /// <param name="lastName"></param>
            public void Deconstruct(out string firstName, out string lastName)
            {
                firstName = FirstName;
                lastName = LastName;
            }
        }
    }
}