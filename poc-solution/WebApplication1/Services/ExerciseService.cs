using System.Collections.Generic;
using WebApplication1.Exceptions;
using WebApplication1.Services.Processors;

namespace WebApplication1.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IProcessor<int, string> _processor;

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="processor">Processor with integer input and string output</param>
        public ExerciseService(IProcessor<int,string> processor)
        {
            _processor = processor;
        }

        /// <summary>
        /// Method for exercise 01
        /// </summary>
        /// <param name="number">Input</param>
        /// <returns>List of strings</returns>
        public IEnumerable<string> ResolveExercise01(int number)
        {
            if (number < 1 || number > 100)
                throw new InvalidInputException("Number must be in a range of 1 to 100");

            var response = new List<string>();

            for (var i = 1; i < number + 1; i++)
            {
                response.Add(_processor.Process(i));
            }

            return response;
        }
    }
}
