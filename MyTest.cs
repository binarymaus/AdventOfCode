using NUnit.Framework;

namespace AdventOfCode
{
    [TestFixture]
    internal class MyTest
    {
        [Test]
        void InputShouldProcudeValidOutput()
        {
            var input = new Input();
            var result = input.SumOfNumber();
            Assert.Equals(52974, result);
        }
    }
}
