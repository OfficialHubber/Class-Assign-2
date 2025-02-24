using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();

        try
        {
            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            int result = Divide(num1, num2);
            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: The entered number is too large.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
    }

    static int Divide(int a, int b)
    {
        return a / b;
    }
}