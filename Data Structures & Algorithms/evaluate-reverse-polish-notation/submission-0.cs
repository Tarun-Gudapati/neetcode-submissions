public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new();

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int number))
            {
                stack.Push(number);
                continue;
            }

            int second = stack.Pop();
            int first = stack.Pop();

            int result = token switch
            {
                "+" => first + second,
                "-" => first - second,
                "*" => first * second,
                "/" => first / second,
                _ => throw new ArgumentException("Invalid operator")
            };

            stack.Push(result);
        }

        return stack.Pop();
    }
}