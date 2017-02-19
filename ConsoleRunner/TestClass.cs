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

        [Theory]
        [InlineData("a", "b")]
        [InlineData("c", "d")]
        public void PassingTheory(string x, string y) { }

        [Theory]
        [InlineData("e", "f", Skip = "Don't run me!")]
        [InlineData("g", "h", Skip = "Don't run me!")]
        public void SkippedTheory(string x, string y) { }
    }
}
