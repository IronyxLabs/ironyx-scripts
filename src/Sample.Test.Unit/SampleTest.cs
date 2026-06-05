namespace Sample.Test.Unit
{
    public class SampleTest
    {
        [Fact(DisplayName = "Pass Test")]
        public void Pass_Test()
        {
            Assert.True(true);
        }

        [Fact(DisplayName = "Fail Test", Skip = "Only for testing the pipeline")]
        public void Fail_Test()
        {
            Assert.Fail("This is a failed test :(");
        }
    }
}
