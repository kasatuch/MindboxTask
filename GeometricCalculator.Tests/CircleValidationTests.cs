using GeometricCalculator.Model.Validation;
using Xunit;

namespace GeometricCalculator.Tests;

public class CircleValidationTests
{
    [Theory]
    [InlineData(2)]
    [InlineData(5.5)]
    [InlineData(0.1)]
    [InlineData(1)]
    public void validationRadius(double radius)
    {
        // Act
        var validationResult = CircleValidation.validationRadius(radius);

        // Assert
        Assert.Equal(validationResult, true);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-0.001)]
    public void validationRadius_ThrowException(double invalidRadius)
    {
        // Act
        Action act = () => CircleValidation.validationRadius(invalidRadius);

        // Assert
        Assert.Throws<Exception>(act);
    }
}