using System.Collections.Generic;

namespace WebApplication1.Services
{
    public interface IExerciseService
    {
        /// <summary>
        /// Method for exercise 01
        /// </summary>
        /// <param name="number">Input</param>
        /// <returns>List of strings</returns>
        IEnumerable<string> ResolveExercise01(int number);
    }
}
