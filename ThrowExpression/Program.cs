using System;

namespace ThrowExpression
{
    /// <summary>
    ///     特性：Throw 表达式
    ///     说明：c#7引入了throw表达式，使用方法与以往的throw用法相同。
    ///     只是在c#7中，你可以将它放到新的地方。
    /// </summary>
    public class Person
    {
        public string  Name { get;  }

        /// <summary>
        ///     构造器初始化
        /// </summary>
        /// <param name="name"></param>
        public Person(string name)
        {
            this.Name = name??
            throw new ArgumentNullException(name);
        }

        /// <summary>
        ///     方法初始化
        /// </summary>
        /// <returns></returns>
        public string GetFirstName()
        {
            var parts = Name.Split(' ');
            return parts.Length>0?parts[0]:
            throw new InvalidOperationException("no name!");
        }

        /// <summary>
        ///     表达式方法体初始化
        /// </summary>
        public string GetLastName=>throw
        new NotImplementedException();

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}