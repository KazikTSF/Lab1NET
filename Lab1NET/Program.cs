namespace Lab1NET;

internal class Program
{
    private static void Main(string[] args)
    {
        const int start = 1;
        const int end = 100;
        var fizzBuzz = new FizzBuzz(start, end);
        for (var i = start; i <= end; i++)
        {
            fizzBuzz.PrintFizzBuzz(i);
        }
    }
}