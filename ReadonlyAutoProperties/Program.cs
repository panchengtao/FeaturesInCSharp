namespace ReadonlyAutoProperties
{
    /// <summary>
    ///     特性：只读自动属性
    /// </summary>
    public class Person
    {
        public Person(int age)
        {
            Age = age;
        }

        public int Age { get; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}