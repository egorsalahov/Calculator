using Calculator;
using Calculator.Patterns;

int result = 0;

CalculatorClass calculator = new CalculatorClass();

string s = Console.ReadLine();
string[] split = s.Split(" "); //четное - число, нечетное - операция


List<int> nums = new List<int>();

for(int i = 0; i < split.Length; i++)
{
    if (i % 2 == 1)
    {
        continue;
    }

    nums.Add(Convert.ToInt32(split[i]));
}

List<string> operations = new List<string>();

for (int i = 0; i < split.Length; i++)
{
    if (i % 2 == 0)
    {
        continue;
    }

    operations.Add(split[i]);
}



for (int i = 0; i < split.Length; i++)
{
    if (i % 2 == 0)
    {
        continue;
    }

    if (split[i].ToString() == "*" ||  split[i].ToString() == "/")
    {
        switch (split[i].ToString())
        {
            case "*": calculator.SetOperation(new Multiply()); result += calculator.DoCalulate(Convert.ToInt32(split[i - 1]), Convert.ToInt32(split[i + 1])); break;
            case "/": calculator.SetOperation(new Divide());result += calculator.DoCalulate(Convert.ToInt32(split[i - 1]), Convert.ToInt32(split[i + 1])); break;
        }
    }

    switch (split[i].ToString())
    {
        case "+": calculator.SetOperation(new Plus()); result += calculator.DoCalulate(Convert.ToInt32(split[i - 1]), Convert.ToInt32(split[i + 1])); break;
        case "-": calculator.SetOperation(new Minus()); result += calculator.DoCalulate(Convert.ToInt32(split[i - 1]), Convert.ToInt32(split[i + 1]));  break;
    }
}

Console.WriteLine(result);