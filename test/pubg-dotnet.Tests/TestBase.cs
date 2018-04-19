using System;
using System.Threading.Tasks;

namespace pubg.net.Tests
{
    public class TestBase : IDisposable
    {
        public void Dispose()
        {
            //Dirty hack to get around the rate limit, remove ASAP
            Task.Delay(30000).GetAwaiter().GetResult();
        }
    }
}
