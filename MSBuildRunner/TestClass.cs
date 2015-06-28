using Xunit;

namespace MSBuildRunner
{
    public class TestClass
    {
        [Fact]
        public void Passing() { }

        [Fact]
        public void Failing()
        {
            Assert.True(false);
        }

        [Fact(Skip = "Don't run me!")]
        public void Skipped() { }
    }
}
