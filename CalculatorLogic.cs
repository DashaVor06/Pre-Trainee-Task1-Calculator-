namespace Task1_Calculator
{
    public class CalculatorLogic
    {
        private List<char> _operations = new List<char>() {'+', '-', '*', '/'};

        public bool TryGetNumber(string? strNum, out int num)
        {
            num = 0;
            if (int.TryParse(strNum, out int res))
            {
                num = res;
                return true;
            }
            return false;
        }

        private bool GetOperationFromString(string? strOper, out char operation)
        {
            operation = '\0';
            if (!string.IsNullOrEmpty(strOper) && _operations.Contains(strOper[0]))
            {
                operation = strOper[0];
                return true;
            }    
            return false;
        }

        public bool GetOperation(string? strOperation, out char operation)
        {
            operation = '\0';  
            if (GetOperationFromString(strOperation, out operation))
                return true;
            return false;
        }

        public bool Calculate(int num1, char oper, int num2, out int result)
        {
            result = 0;
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
                        return false;
                    else
                        result = num1 / num2;
                    break;
            }
            return true;
        }
    }
}
