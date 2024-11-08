using System;

namespace Tribonacci;

public class Xbonacci
{
	public static double[] Tribonacci(double[] signature, int length)
	{
		var array = new double[length];

		Array.Copy(signature, array, Math.Min(signature.Length, length));

		for (var index = 3; index < array.Length; index++)
		{
			array[index] = SumLastThreeNumbers(array, index);
		}

		return array;
	}

	private static double SumLastThreeNumbers(double[] array, int index)
	{
		return array[index - 1] + array[index - 2] + array[index - 3];
	}
}