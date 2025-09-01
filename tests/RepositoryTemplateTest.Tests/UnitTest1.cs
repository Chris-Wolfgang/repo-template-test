using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace RepositoryTemplateTest.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Assert.True(true);
            //Assert.Fail();
        }


        [Fact]
        public void Test2()
        {
            ProgramApp.Main([]);
        }


        [Fact]
        public void Test3()
        {
            ProgramApp.Main([""]);
        }

    }
}