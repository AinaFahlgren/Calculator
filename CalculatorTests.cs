using Xunit;


public class CalculatorTests
{
    [Fact] //visar att det är ett test
    public void TestAddition()
    {
        // given (exempel där additionen testas)
        Calculator calc = new();
        int a = 5;
        int b = 2;
        int expectedResult = 7;

        // when (utförs när)
        int result = calc.Add(a, b);

        // then
        Assert.Equal(expectedResult, result);
    }
}