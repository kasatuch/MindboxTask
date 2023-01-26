using GeometricCalculator.Interfaces;
using GeometricCalculator.Model.Validation;

namespace GeometricCalculator.Function
{
    public class Circle : IModel
    {
        /// <summary>
        /// Circle radius
        /// </summary>
        private readonly double _r;

        /// <summary>
        /// Constructor with parameter 
        /// </summary>
        /// <param name="r">Circle radius</param>
        public Circle (double r)
        {
            if (CircleValidation.validationRadius(r) == true)
                _r = r;
        }
        public double areaModel()
        {           
            return Math.PI * Math.Pow(_r,2);          
        }
    }

}
