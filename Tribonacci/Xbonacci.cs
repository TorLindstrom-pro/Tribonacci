namespace Tribonacci;

public class Xbonacci
{
	public static int[] Tribonacci(int[] signature, int length)
	{
		var array = new int[length];
		
		signature.CopyTo(array, 0);

		for (var index = 3; index < array.Length; index++)
		{
			array[index] = SumLastThreeNumbers(array, index);
		}

		return array;
	}

	private static int SumLastThreeNumbers(int[] array, int index)
	{
		return array[index - 1] + array[index - 2] + array[index - 3];
	}
}