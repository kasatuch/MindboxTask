namespace GeometricCalculator.Model.Validation
{
    public class TriangleValidation
    {
        /// <summary>
        /// Validation edges on correctness
        /// </summary>
        /// <param name="a">First edge</param>
        /// <param name="b">Second edge</param>
        /// <param name="c">Third edge</param>
        /// <returns>True or false validation</returns>
        public static bool valiadtionTriangleEdge(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Not correct arg");
            else if (a + b < c || b + c < a || c + a < b)
                throw new Exception("Сan't exist");
            else
                return true;
        }
        /// <summary>
        /// Validation triangle is right
        /// </summary>
        /// <param name="a">First edge</param>
        /// <param name="b">Second edge</param>
        /// <param name="c">Third edge</param>
        /// <returns>True or false validation</returns>
        public static bool valiadtionTriangleIsRight(double a, double b, double c)
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                return false;
            else if (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
                return false;
            else if (Math.Pow(c, 2) + Math.Pow(a, 2) == Math.Pow(b, 2))
                return false;
            else
                return true;
        }
    }
}
