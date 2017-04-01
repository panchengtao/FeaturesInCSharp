using System;
using System.Threading.Tasks;

namespace GeneralizedAsyncReturnTypes
{
    /// <summary>
    ///     特性：异步返回类型
    ///     说明：该特性其实十分容易理解，以往的异步返回类型只能是void，task，以及Task<T>，
    ///     返回后两者时，由于Task是一个引用类型，所以势必需要分配一个对象，在部分场景中，如
    ///     async关键字修饰的获取缓存对象及同步调用中（即不进行异步操作），额外的分配可能意味着性能瓶颈成本。
    ///     所以新的.NET框架中内置了ValueTask类型（struct），供返回上述三种类型外的其他TResult。
    /// 
    ///     想要使用该类型需要安装System.Threading.Tasks.Extensions nuget包。
    ///     ValueTask结构具有一个带参数的Task类型重载，以便可以从任何现有异步方法的返回值构造一个ValueTask
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public async ValueTask<int> Func()
        {
            await Task.Delay(100);
            return 5;
        }

        public ValueTask<int> CachedFunc()
        {
            return (cache) ? new ValueTask<int>(cacheResult) : new ValueTask<int>(loadCache());
        }
        private bool cache = false;
        private int cacheResult;
        private async Task<int> loadCache()
        {
            // simulate async work:
            await Task.Delay(100);
            cache = true;
            cacheResult = 100;
            return cacheResult;
        }
    }
}