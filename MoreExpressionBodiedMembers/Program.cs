using System;

namespace MoreExpressionBodiedMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }

    /// <summary>
    ///     特性：更多的表达式成员
    ///     说明：c#6提供了表达式方法体成员特性，c#7则扩展了该特性的功能
    ///     在c#7中，你可以用lambda表达式实现构造器，终接器，get，set方法以及索引器
    /// </summary>
    public class ExpressionMembersExample
    {
        // Expression-bodied constructor
        public ExpressionMembersExample(string label) => this.Label = label;

        // Expression-bodied finalizer
        ~ExpressionMembersExample() => Console.Error.WriteLine("Finalized!");

        private string label;

        // Expression-bodied get / set accessors.
        public string Label
        {
            get => label;
            set => this.label = value ?? "Default label";
        }
    }
}