using Tribonacci;

namespace Test;

public class UnitTest1
{
    [Fact(DisplayName = "All zeroes in signature returns empty array")]
    public void AllZeroesInSignature_ReturnsEmptyArray()
    {
        var result = Xbonacci.Tribonacci([0, 0, 0]);
        
        Assert.Empty(result);
    }
}