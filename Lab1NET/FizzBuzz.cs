using System.Text;

namespace Lab1NET;

public class FizzBuzz(int min, int max)
{
    private readonly int _max = max;
    private readonly int _min = min;

    public void PrintFizzBuzz(int num)
    {
        if (num < _min || num > _max)
        {
            return;
        }
        var output = new StringBuilder();
        if (num % 3 == 0)
        {
            output.Append("Fizz");
        }
        if (num % 5 == 0)
        {
            output.Append("Buzz");
        }
        
        Console.WriteLine(output.ToString() == "" ? num.ToString() : output.ToString());
    }
}