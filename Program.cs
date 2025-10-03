using Task1_Calculator;

var calc = new CalculatorLogic();

bool fSearchExit = true, fEnteredExit = false, fDevideByZero = false;

while (true)
{
    int num1 = calc.GetNumberOrExit("Enter first number or command 'exit': ", fSearchExit, out fEnteredExit);
    if (fEnteredExit) 
        break;

    char oper = calc.GetOperation("Enter operation: ");

    int num2 = calc.GetNumberOrExit("Enter second number: ", !fSearchExit, out fEnteredExit);

    int result = calc.Calculate(num1, oper, num2, out fDevideByZero);
    if (!fDevideByZero)
        Console.WriteLine("Result of operation: " + result);
    else
        Console.WriteLine("Devide by zero exeption");
}
