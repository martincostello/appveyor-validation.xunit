using System.Threading.Tasks;
using Xunit;

namespace ConsoleRunner
{
    public class TestClass
    {
        [Fact]
        public void Passing() { }

        [Fact]
        public async void Failing()
        {
            await Task.Delay(0);
            Assert.True(false);
        }

        [Fact(Skip = "Don't run me!")]
        public void Skipped() { }
    }
}
