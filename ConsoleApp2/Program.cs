using System.Numerics;
string[] operations = new string[4] { "division", "multiplication", "addition", "subtraction" };
List<int> histories = new List<int>();

while (true)
{
    Console.Write("Enter the first number: ");
    int firstNum = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number: ");
    int secondNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    bool firstNumCon = firstNum > 0 && firstNum < 100 ? true : false;
    bool secondNumCon = secondNum > 0 && secondNum < 100 ? true : false;

    int result;

    if (firstNumCon && secondNumCon)
    {
        Console.WriteLine("Choose the appropriate number for your desired operation");

        for (int i = 1; i < operations.Length + 1; i++)
        {
            Console.WriteLine($"{i}.({operations[i - 1]})");
        }

        int selectedOperation = Convert.ToInt32(Console.ReadLine());

        switch (selectedOperation)
        {
            case 1:
                result = firstNum / secondNum;
                break;
            case 2:
                result = firstNum * secondNum;
                break;
            case 3:
                result = firstNum + secondNum;
                break;
            case 4:
                result = firstNum - secondNum;
                break;
            default:
                result = 0;
                break;
        }

        Console.WriteLine(result);
        histories.Add(result);

        Console.WriteLine("Your history: ");
        foreach (int history in histories)
        {
            Console.WriteLine(history);
        }
    }
    else
    {
        Console.WriteLine("you need to enter numbers from 0 to 100");
    }
}

