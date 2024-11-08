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
    
    [Fact(DisplayName = "All ones in signature returns normal tribonacci sequence")]
    public void AllOnesInSignature_ReturnsNormalTribonacciSequence()
    {
        var result = Xbonacci.Tribonacci([1, 1, 1], 7);
        
        Assert.Equal([1, 1, 1, 3, 5, 9, 17], result);
    }
}