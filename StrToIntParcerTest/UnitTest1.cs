using Microsoft.VisualStudio.TestPlatform.TestHost;
using StringParce;

namespace StrToIntParcerTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string input = "two hundred forty-six";
            int expected = 246;
            int actual = SrtringParcer.ParseInt(input);
            Assert.Equal(expected, actual);
        }
        [Fact] 
        public void Test783919()
        {
            string input = "seven hundred eighty-three thousand nine hundred and nineteen";
            int expected = 783919;
            int actual = SrtringParcer.ParseInt(input);
            Assert.Equal(expected, actual);
        }
    }
}