namespace GeometricCalculator.Model.Validation
{
    public class CircleValidation
    {
        /// <summary>
        /// Validation Radius on positivity
        /// </summary>
        /// <param name="r">Cirlce radius</param>
        /// <returns>True or false validation</returns>
        public static bool validationRadius(double r)
        {
            if (r <= 0)
                throw new Exception("Radius not correct");
            else
                return true;
        }
    }
}
