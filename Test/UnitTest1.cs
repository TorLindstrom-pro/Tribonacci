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
}