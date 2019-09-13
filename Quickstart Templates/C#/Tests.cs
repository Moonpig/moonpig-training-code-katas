namespace CodeKatas
{
    using Shouldly;
    using Xunit;

    public class Tests
    {
        [Fact]
        public void TrueIsTrue()
        {
            true.ShouldBe(true);
        }
    }
}