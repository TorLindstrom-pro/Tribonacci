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
    
    [Theory(DisplayName = "Tribonacci sequence is returned based on signature"), MemberData("TribonacciData")]
    public void AllOnesInSignature_ReturnsNormalTribonacciSequence(int[] signature, int[] expected)
    {
        var result = Xbonacci.Tribonacci(signature, 8);
        
        Assert.Equal(expected, result);
    }
    
    public static IEnumerable<object[]> TribonacciData()
    {
        yield return [new[] {1, 1, 1}, new[] {1, 1, 1, 3, 5, 9, 17, 31}];
        yield return [new[] {0, 1, 1}, new[] {0, 1, 1, 2, 4, 7, 13, 24}];
        yield return [new[] {0, 0, 1}, new[] {0, 0, 1, 1, 2, 4, 7, 13}];
    }
}