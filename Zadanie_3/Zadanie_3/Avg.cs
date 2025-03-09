namespace Zadanie_3;

public class Avg
{
    public static double Avrage(double[] numbers)
    {
        if (numbers.Length == 0 || numbers == null)
        {
            throw new ArgumentException("Array cannot be empty or null lalalalalal");
        }

        return numbers.Average();
    }
}