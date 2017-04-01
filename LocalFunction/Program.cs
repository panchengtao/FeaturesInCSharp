using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunction
{
    /// <summary>
    ///     特性：局部函数
    ///     说明：有时，一个辅助函数只在一个使用它的单一方法的内部有意义。
    ///     现在你可以在其他功能体内部以一个局部函数来声明这样的函数。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in AlphabetSubset('a', 'z'))
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }

        public static IEnumerable<char> AlphabetSubset(char start, char end)
        {
            if ((start < 'a') || (start > 'z'))
                throw new ArgumentOutOfRangeException(paramName: nameof(start), message: "start must be a letter");
            if ((end < 'a') || (end > 'z'))
                throw new ArgumentOutOfRangeException(paramName: nameof(end), message: "end must be a letter");

            if (end <= start)
                throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");

            return AlphabetSubsetImplementation();

            // 闭合范围内的参数和局部变量在局部函数内是可用的
            IEnumerable<char> AlphabetSubsetImplementation()
            {
                for (var c = start; c < end; c++)
                    yield return c;
            }
        }
    }
}
