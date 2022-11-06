using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures
{
    public class Triangle : Figure
    {
        public override double EvaluateArea()
        {
            if (IsRight())
            {
                var distances = GetSortedDistances();
                return distances[1].Length * distances[0].Length / 2;
            }
            else
            {
                var halfPerimeter = (from d in GetSortedDistances() select d.Length).Sum() / 2;
                return Math.Sqrt(halfPerimeter * (halfPerimeter - A.Length) * 
                                (halfPerimeter - B.Length) * (halfPerimeter - C.Length));
            }
        }

        /// <summary>
        /// First side
        /// </summary>
        public Distance A { get; private set; }

        /// <summary>
        /// Second side
        /// </summary>
        public Distance B { get; private set; }

        /// <summary>
        /// Third side
        /// </summary>
        public Distance C { get; private set;  }


        /// <summary>
        /// New triangle
        /// </summary>
        /// <param name="a">First side</param>
        /// <param name="b">Second Side</param>
        /// <param name="c">Third side</param>
        public Triangle(Distance a, Distance b, Distance c)
        {
            A = a;
            B = b;
            C = c;
            if (EvaluateArea() <= 0)
            {
                throw new ArgumentException("Triangle doesn't exist");
            }
        }

        /// <summary>
        /// Check if triangle is right
        /// </summary>
        /// <returns>True if right, otherwise false</returns>
        public bool IsRight()
        {
            var distances = GetSortedDistances();
            if (distances[2].Length * distances[2].Length ==
                distances[1].Length * distances[1].Length + distances[0].Length * distances[0].Length)
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Gets collection of a sorted distances
        /// </summary>
        /// <returns>Sorted distances</returns>
        private List<Distance> GetSortedDistances()
        {
            List<Distance> distances = new List<Distance>() { A, B, C };
            distances.Sort();
            return distances;
        }


    }
}
