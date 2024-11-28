using ConsoleApp1;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void estStraight_Homme1_Return_True()
        {
            const int homme = 1;
            bool result = tamere.estStraight(homme);

            Assert.True(result);
        }
    }
}