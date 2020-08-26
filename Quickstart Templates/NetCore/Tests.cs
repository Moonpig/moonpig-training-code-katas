namespace CodeKatas
{
    using Shouldly;
    using Xunit;

    public class Tests
    {
        [Fact]
        public void SampleSuccess()
        {
            true.ShouldBeTrue();
        }

        [Fact]
        public void SampleFailed()
        {
            true.ShouldBeFalse();
        }
    }
}
