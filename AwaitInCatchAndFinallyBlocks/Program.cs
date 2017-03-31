using System;
using System.Threading.Tasks;

namespace AwaitInCatchAndFinallyBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        ///     特性：在catch和finally中使用await
        ///     说明：在c#6中，我们终于可以在catch和finally中使用await操作符了，
        ///     这与在普通代码中使用await操作符是一样的，我们的代码也因此变得更加连贯和优雅。
        /// </summary>
        /// <returns></returns>
        public static async Task<string> MakeRequestAndLogFailures()
        {
            //await logMethodEntrance();
            var client = new System.Net.Http.HttpClient();
            var streamTask = client.GetStringAsync("https://localHost:10000");
            try
            {
                var responseText = await streamTask;
                return responseText;
            }
            catch (System.Net.Http.HttpRequestException e) when (e.Message.Contains("301"))
            {
                //await to do something
                //await logError("Recovered from redirect", e);
                return "Site Moved";
            }
            finally
            {
                //await to do something
                //await logMethodExit();
                client.Dispose();
            }
        }
    }
}