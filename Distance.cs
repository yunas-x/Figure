using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    /// <summary>
    /// Base class for all lines
    /// </summary>
    public class Distance: IComparable<Distance>
    {
        private double length;

        /// <summary>
        /// Length of a line
        /// Throws exception if distance is zero or less
        /// </summary>
        public double Length 
        {
            get => length;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Couldn't be zero or less");
                }
                else
                {
                     length = value;
                }
            }
        }

        /// <summary>
        /// A distance between two points
        /// </summary>
        /// <param name="len">The length of line</param>
        public Distance(double len)
        {
            Length = len;
        }

        public int CompareTo(Distance distance)
        {
            if (this == null)
            {
                if (distance == null)
                {
                    return 0;
                }
                else return -1;
            }
            if (distance == null)
            {
                return 1;
            }

            return Length.CompareTo(distance.Length);
        }
    }
}
