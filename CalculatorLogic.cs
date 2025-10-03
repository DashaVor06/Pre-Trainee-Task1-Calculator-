namespace Task1_Calculator
{
    public class CalculatorLogic
    {
        private List<char> _operations = new List<char>() {'+', '-', '*', '/'};
        public int GetNumberOrExit(string text, bool fSearchExit, out bool fEnteredExit)
        {
            int num = 0, res;
            fEnteredExit = false;
            do
            {
                Console.WriteLine(text);
                string? strNum = Console.ReadLine();

                if (fSearchExit && strNum == "exit")
                {
                    fEnteredExit = true;
                    break;
                }

                if (int.TryParse(strNum, out res))
                {
                    num = res;
                    break;
                }

            } while (true);

            return num;
        }

        char? GetOperationFromString(string? strOper)
        {
            if (strOper != null && strOper != "" && _operations.Contains(strOper[0]))
                return strOper[0];
            return null;
        }

        public char GetOperation(string text)
        {
            char? operation;
            do
            {
                Console.WriteLine(text);
                string? strOperation = Console.ReadLine();
                operation = GetOperationFromString(strOperation);
            } while (operation == null);

            return (char)operation;
        }

        public int Calculate(int num1, char oper, int num2, out bool fDevideByZero)
        {
            int result = 0;
            fDevideByZero = false;
            switch (oper)
            {
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
                        fDevideByZero = true;
                    else
                        result = num1 / num2;
                    break;
            }
            return result;
        }
    }
}
