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
}