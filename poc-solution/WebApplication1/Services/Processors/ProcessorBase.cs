namespace WebApplication1.Services.Processors
{
    /// <summary>
    /// Base class for processors
    /// </summary>
    /// <typeparam name="T">Input type</typeparam>
    /// <typeparam name="M">Output type</typeparam>
    public abstract class ProcessorBase<T,M>: IProcessor<T, M>
    {
        /// <summary>
        /// Process method
        /// </summary>
        /// <param name="input">input</param>
        /// <returns>Output</returns>
        public abstract M Process(T input);
    }
}
