using System;

namespace ExceptionFilters
{
    internal class Program
    {
        /// <summary>
        ///     特性：异常过滤器
        ///     说明：在捕获异常时异常新增一个条件过滤器，
        ///     以指示是否继续运行异常处理代码。并且同个异常能捕获多次
        /// </summary>
        /// <returns></returns>
        private static void Main(string[] args)
        {
            try
            {
                throw new ArgumentException("Age");
            }
            catch (ArgumentException argumentException) when (argumentException.Message.Equals("Name"))
            {
                throw new ArgumentException("Name Exception");
            }

            catch (ArgumentException argumentException) when (argumentException.Message.Equals("Age"))
            {
                throw new Exception("not handle");
            }
        }
    }
}