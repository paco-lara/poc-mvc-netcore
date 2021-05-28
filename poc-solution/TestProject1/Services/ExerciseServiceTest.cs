using NUnit.Framework;
using System.Linq;
using WebApplication1.Exceptions;
using WebApplication1.Services;
using WebApplication1.Services.Processors;

namespace TestProject1.Services
{
    public class ExerciseServiceTest
    {
        [TestCase(3, "1,2,Fizz")]
        [TestCase(5, "1,2,Fizz,4,Buzz")]
        public void ResolveExercise01_Success(int input, string expectedOutput)
        {
            var processor = new ProcessorNumber();
            var exerciseService = new ExerciseService(processor);
            var output = exerciseService.ResolveExercise01(input);
            var expectedList = expectedOutput.Split(',').ToList();
            Assert.IsTrue(output.All(d => expectedList.Contains(d)));
        }

        [TestCase(-1)]
        [TestCase(1000)]
        public void ResolveExercise01_Failure(int input)
        {
            var processor = new ProcessorNumber();
            var exerciseService = new ExerciseService(processor);
            Assert.Throws<InvalidInputException>(() => exerciseService.ResolveExercise01(input));
        }


    }
}
