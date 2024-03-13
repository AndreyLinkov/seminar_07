//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

int CheckInput(string message)
{
    bool isInputValue = true;
    int num;
    do
    {
        Console.Write(message);
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out num))
        {
            isInputValue = false;
        }
         else
            Console.WriteLine("Ошибка ввода!");
    } while (isInputValue);

    return num;
}

void Operation(int firstNum, int secondNum)
{
    int num = firstNum;
    Console.Write($"{num} ");

    if (num == secondNum) {
        return;
    }
    else {
        Operation(firstNum + 1, secondNum);
    }
}

int firstNumber = CheckInput("Введите первое число: ");
int secondNumber = CheckInput("Введите второе число: ");

Operation(firstNumber, secondNumber);