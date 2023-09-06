Console.WriteLine("Enter two numbers: ");
short num1 = Convert.ToInt16(Console.ReadLine()), num2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Choose operation: \n1 - sum\n2 - minus\n3 - multiply\n4 - divide");
short num = Convert.ToInt16(Console.ReadLine());

MathOperations.MathOperation(num, num1, num2);

static class MathOperations
{
    private delegate int Operation(int a, int b);
    private static int Plus(int a, int b) => a + b;
    private static int Minus(int a, int b) => a - b;
    private static int Multiply(int a, int b) => a * b;
    private static int Divide(int a, int b) => a / b;
    public static void MathOperation(int x, int a, int b)
    {
        Operation operation;
        switch(x)
        {
            case 1: operation = Plus; break;
            case 2: operation = Minus; break;
            case 3: operation = Multiply; break;
            case 4: operation = Divide; break;
            default: throw new Exception();
        };
        Console.WriteLine(operation(a, b));
    }
}