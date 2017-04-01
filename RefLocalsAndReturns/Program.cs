using System;

namespace RefLocalsAndReturns
{
    /// <summary>
    ///     特性：引用返回和局部引用
    ///     说明：就像在C＃中你可以通过引用（用ref修饰符）传递参数，
    ///     你现在也可以通过引用来返回参数，并通过引用将它们存储在局部变量中。
    /// 
    ///     这个是非常有用的。
    ///     例如，一个游戏可能会将它的数据保存在一个大的预分配数组结构中（为避免垃圾回收机制暂停）。
    ///     这个方法可以直接返回一个引用到这样一个结构，且通过调用者可以读取和修改它。
    ///    
    ///     为确保安全，也有以下一些限制：
    ///     1. 你只能返回”安全返回”的引用：一个是传递给你的引用，一个是指向对象中的引用
    ///     2. 本地引用会被初始化成一个本地存储，并且不能指向另一个存储
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] {1, 3, 5, 7, 9, 33, 44};
            Console.WriteLine(array[3]);
            ref int place =ref new Program().Find(7, array);
            place = 10;
            Console.WriteLine(array[3]);

            Console.ReadKey();
        }

        public ref int Find(int number, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (number == numbers[i])
                {
                    return ref numbers[i];
                }
            }
            throw new IndexOutOfRangeException();
        }
    }
}