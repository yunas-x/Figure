using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    /// <summary>
    /// This is an Interface used to evaluate Area
    /// </summary>
    public interface IEvaluateArea
    {
        /// <summary>
        /// Evaluate area of this figure
        /// </summary>
        /// <returns>Area (in square units)</returns>
        public double EvaluateArea();
    }
}
