using Tribonacci;

namespace Test;

public class UnitTest1
{
    [Fact(DisplayName = "All zeroes in signature returns only zeroes")]
    public void AllZeroesInSignature_ReturnsOnlyZeroes()
    {
        var result = Xbonacci.Tribonacci([0, 0, 0], 5);
        
        Assert.Equal(result, [0, 0, 0, 0, 0]);
    }

    [Theory(DisplayName = "Length of result is equal to length argument")]
    [InlineData(3, new[] {0, 0, 0})]
    [InlineData(7, new[] {0, 0, 0, 0, 0, 0, 0})]
    public void LengthOfResult_IsEqualToLengthArgument(int length, int[] expectedResult)
    {
        var result = Xbonacci.Tribonacci([0, 0, 0], length);
        
        Assert.Equal(expectedResult, result);
    }
}