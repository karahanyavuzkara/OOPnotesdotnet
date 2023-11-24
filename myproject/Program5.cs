class Program {
    public static void Main(string[]args) {

    Console.WriteLine("Enter the first number : ");
    String num1Value = Console.ReadLine();
    int num1 = Convert.ToInt32(num1Value);

    Console.WriteLine("Enter the second number : ");
    String num2Value = Console.ReadLine();
    int num2 = Convert.ToInt32(num2Value);

    Console.WriteLine("Enter the third number : ");
    String num3Value = Console.ReadLine();
    int num3 = Convert.ToInt32(num3Value);

    Console.WriteLine("Sum of the numbers you have entered: " + (num3 + num2 + num1) );

    }
}