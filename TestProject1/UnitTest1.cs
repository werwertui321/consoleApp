using ConsoleApp1TEST;

namespace TestProject1
{
    public class Tests
    {
        

        [Test]
        public void Test1()
        {
            bool result = tamere.estStraight(1);

            Assert.That(result, Is.True);
        }

        [Test]
        public void Test2()
        {
            bool result = tamere.estStraight(5);

            Assert.That(result, Is.False);
        }
    }
}