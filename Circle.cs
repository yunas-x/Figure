using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    /// <summary>
    /// A circle figure
    /// For which area could be evaluated
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Radius of a circle
        /// </summary>
        public Distance Radius { get; private set; }

        /// <summary>
        /// A circle with a radius of a given distance
        /// </summary>
        /// <param name="radius"></param>
        public Circle(Distance radius)
        {
            Radius = radius;
        }


        public override double EvaluateArea()
        {
            return Math.PI * Radius.Length * Radius.Length;
        }
    }
}
