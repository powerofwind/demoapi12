namespace Demoapi.Controllers
{
    public class CalculateLogic
    {
        public int Calculate(int input1, string operation, int input2)
        {
            if (operation == "+")
            {
                return input1 + input2;
            }
            if (operation == "-")
            {
                return input1 - input2;
            }
            if (operation == "*")
            {
                return input1 * input2;
            }
            if (operation == "/")
            {
                return input1 / input2;
            }
            return 0;
            
        }
    }
}