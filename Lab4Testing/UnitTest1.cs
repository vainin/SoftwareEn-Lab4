using Lab3;

namespace Lab4Testing
{
    public class Tests
    {
        private BusinessLogic bl = new BusinessLogic();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}