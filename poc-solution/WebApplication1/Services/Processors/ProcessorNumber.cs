namespace WebApplication1.Services.Processors
{
    public class ProcessorNumber : ProcessorBase<int, string>
    {
        /// <summary>
        /// Returns FizzBuzz for numbers multiple of 3 and 5,
        /// Fizz for multiple of 3 and Buzz for multiple of 5
        /// </summary>
        /// <param name="input">Number to process</param>
        /// <returns>Output according to process</returns>
        public override string Process(int input)
        {
            var mod3 = (input % 3) == 0;
            var mod5 = (input % 5) == 0;

            return mod3 && mod5 ? "FizzBuzz" : mod3 ? "Fizz" : mod5 ? "Buzz" : input.ToString();
        }
    }
}
