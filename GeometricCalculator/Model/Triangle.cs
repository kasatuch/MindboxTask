using GeometricCalculator.Interfaces;
using GeometricCalculator.Model.Validation;

namespace GeometricCalculator.Function
{
    public class Triangle : IModel
    {
        /// <summary>
        /// First edge
        /// </summary>
        private readonly double _a;

        /// <summary>
        /// Second edge
        /// </summary>
        private readonly double _b;

        /// <summary>
        /// Third edge
        /// </summary>
        private readonly double _c;

        /// <summary>
        /// Constuctor with parametrs edges
        /// </summary>
        /// <param name="a">First edge</param>
        /// <param name="b">Second edge</param>
        /// <param name="c">Third edge</param>
        public Triangle(double a, double b, double c)
        {
            if (TriangleValidation.valiadtionTriangleEdge(a, b, c) == true)
            {
                _a = a;
                _b = b;
                _c = c;
            }
        }
        public double areaModel()
        {
            //HeronFun
            return Math.Sqrt(((_a + _b + _c)/2) - (((_a+_b+_c)/2)-_a) - (((_a + _b + _c)/2) - _b) - (((_a + _b + _c)/2) - _c)); 
        }
    }
}
