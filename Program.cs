using Task1_Calculator;

var calc = new CalculatorLogic();

while (true)
{
    string? str;

    //Get first number
    int num1;
    Console.WriteLine("Enter first number or command 'exit':");
    while (true)
    {     
        str = Console.ReadLine();

        if (str == "exit")
            return 0;

        if (calc.TryGetNumber(str, out num1))
            break;

        Console.WriteLine("Mistake. Enter first number or command 'exit':");
    }

    //Get operation
    char operation;
    Console.WriteLine("Enter operation: "); 
    while (true)
    {
        str = Console.ReadLine();
        if (calc.GetOperation(str, out operation))
            break;

        Console.WriteLine("Mistake. Enter operation: ");
    }

    //Get second number
    int num2;
    Console.WriteLine("Enter second number:"); 
    while (true)
    {
        str = Console.ReadLine();
        if (calc.TryGetNumber(str, out num2))
            break;

        Console.WriteLine("Mistake. Enter second number:");
    }

    //Calculations
    int result;
    if (calc.Calculate(num1, operation, num2, out result))
        Console.WriteLine("Result of operation: " + result);
    else
        Console.WriteLine("Devide by zero exeption");
}
