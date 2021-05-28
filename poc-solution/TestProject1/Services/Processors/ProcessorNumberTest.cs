using NUnit.Framework;
using WebApplication1.Services.Processors;

namespace TestProject1.Services.Processors
{
    public class ProcessorNumberTest
    {
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void Process_Success(int input, string expectedOutput)
        {
            var processor = new ProcessorNumber();
            var output = processor.Process(input);
            Assert.AreEqual(expectedOutput, output);
        }
    }
}
