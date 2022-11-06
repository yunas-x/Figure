namespace Figures
{
    /// <summary>
    /// Base class for all figures
    /// </summary>
    public abstract class Figure : IEvaluateArea  // Another interfaces could be added
    { 

        public abstract double EvaluateArea();
    }
}