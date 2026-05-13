using CalculatorApp;
using Xunit;

namespace CalculatorApp.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ShouldReturnSum_WhenTwoIntegers()
    {
        // Arrange
        var calc = new Calculator();
        int a = 2, b = 3;

        // Act
        int result = calc.Add(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_ShouldReturnDifference()
    {
        var calc = new Calculator();
        int result = calc.Subtract(5, 3);
        Assert.Equal(2, result);
    }
}