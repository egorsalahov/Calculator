using Calculator;
using Calculator.Patterns;

string s = Console.ReadLine();
string[] split = s.Split(" ");
int i = Convert.ToInt32(split[0]);
int j = Convert.ToInt32(split[2]);

CalculatorClass calculator = new CalculatorClass();

switch (split[1].ToString())
{
    case "+": calculator.SetOperation(new Plus()); calculator.DoCalulate(i, j); break;
    case "-": calculator.SetOperation(new Minus()); calculator.DoCalulate(i, j); break;
    case "*": calculator.SetOperation(new Multiply()); calculator.DoCalulate(i, j); break;
    case "/": calculator.SetOperation(new Divide()); calculator.DoCalulate(i, j); break;
    default: Console.WriteLine("Такой операции нет"); break;
}
