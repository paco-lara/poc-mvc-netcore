namespace WebApplication1.Services.Processors
{
    /// <summary>
    /// Processor contract
    /// </summary>
    /// <typeparam name="T">Input type</typeparam>
    /// <typeparam name="M">Output type</typeparam>
    public interface IProcessor<T, M>
    {
        /// <summary>
        /// Process method
        /// </summary>
        /// <param name="input">input</param>
        /// <returns>Output</returns>
        M Process(T input);
    }
}
