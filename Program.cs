int? getNumFromStr(string? strNum)
{
    if (strNum == null || strNum == "")
        return null;
    foreach (char symbol in strNum)
    {
        if (symbol < '0' || symbol > '9')
            return null;
    }
    return int.Parse(strNum);
}

int getNum(string text)
{
    int? num;
    do
    {
        Console.WriteLine(text);
        string? strNum = Console.ReadLine();
        num = getNumFromStr(strNum);
    } while (num == null);

    return (int)num;
}

int? getNumOrExit(string text)
{
    int? num;
    do
    {
        Console.WriteLine(text);
        string? strNum = Console.ReadLine();
        if (strNum == "exit")
            return null;
        num = getNumFromStr(strNum);
    } while (num == null);

    return num;
}

char? getOperFromStr(string? strOper)
{
    if (strOper != null && (strOper[0] == '+' || strOper[0] == '+' || strOper[0] == '*' || strOper[0] == '/'))
        return strOper[0];
    return null;
}

char getOper(string text)
{
    char? operation;
    do
    {
        Console.WriteLine(text);
        string? strOperation = Console.ReadLine();
        operation = getOperFromStr(strOperation);
    } while (operation == null);

    return (char)operation;
}

int? calculate(int num1, char oper, int num2)
{
    int? result = 0;
    switch (oper) {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*': 
            result = num1 * num2;
            break;
        case '/':
            if (num2 == 0)
            {
                Console.WriteLine("Devide by zero exeption");
                result = null;
            }
            else
                result = num1 / num2;
            break;
    }
    return result;
}

bool fExit = false;
while (!fExit)
{
    int? num1 = getNumOrExit("Enter first number or command 'exit': ");
    if (num1 == null)
    {
        fExit = true;
        break;
    }
    char oper = getOper("Enter operation: ");
    int num2 = getNum("Enter second number: ");

    int? result = calculate((int)num1, oper, num2);
    if (result != null)
        Console.WriteLine("Result of operation: " + result);
}
