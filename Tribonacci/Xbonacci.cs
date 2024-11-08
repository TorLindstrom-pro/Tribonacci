namespace Tribonacci;

public class Xbonacci
{
	public static int[] Tribonacci(int[] signature, int length)
	{
		var array = new int[length];
		
		signature.CopyTo(array, 0);

		for (var index = 3; index < array.Length; index++)
		{
			array[index] = array[index - 1] + array[index - 2] + array[index - 3];
		}

		return array;
	}
}