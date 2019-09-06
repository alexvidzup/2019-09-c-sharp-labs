using NUnit.Framework;
using lab_12_test_me_out;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void Test1()
        {
            var expected = 100;
            var actual = TestMeSomething.RunThisTestNow(10);
            Assert.AreEqual(expected, actual);
            
        }
        [TestCase(10, 100)]
        [TestCase(100, 10000)]
        [TestCase(9, 82)]
        public void TestMeSomething_RunTestMeNow_Tests(int input, int expected)
        {
            var actual = TestMeSomething.RunThisTestNow(input);
            Assert.AreEqual(expected, actual);
        }

        public void TestRabbitExplosion(int populationLimit, int expectedYears)
        {
            // arrange

            // act
        }
    }
}