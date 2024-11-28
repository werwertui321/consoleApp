using ConsoleApp1;

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
    }
}