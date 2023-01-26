using GeometricCalculator.Model.Validation;
using Xunit;

namespace GeometricCalculator.Tests
{
    public class TriangleValidationTests
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(0.001, 0.002, 0.003)]
        [InlineData(2234, 5432, 4321)]
        public void valiadtionTriangleEdge(double a, double b, double c)
        {
            // Act
            var validationResult = TriangleValidation.valiadtionTriangleEdge(a,b,c);

            // Assert
            Assert.Equal(validationResult, true);
        }

        [Theory]
        [InlineData(0.1, 2, 3)]
        [InlineData(-0.001, -0.002, -0.003)]
        [InlineData(123, 5432, 4321)]
        public void valiadtionTriangleEdge_ThrowException(double a, double b, double c)
        {
            // Act
            Action act = () => TriangleValidation.valiadtionTriangleEdge(a,b,c);

            // Assert
            Assert.Throws<Exception>(act);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(0.001, 0.002, 0.003)]
        [InlineData(2234, 5432, 4321)]
        public void valiadtionTriangleIsRight(double a, double b, double c)
        {
            // Act
            var validationResult = TriangleValidation.valiadtionTriangleIsRight(a,b,c);

            //Assert
            Assert.Equal(validationResult, true);
        }
    }
}
