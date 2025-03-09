namespace Zadanie_3;

public class Max
{
    public static double MaxNumber(double[] numbers)
    {
        if (numbers.Length == 0 || numbers == null)
        {
            throw new ArgumentException("Array cannot be empty or null");
        }

        return numbers.Max();
    }
}