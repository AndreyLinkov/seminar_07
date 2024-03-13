// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

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

int Akerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Akerman(m - 1, 1);
    else
        return Akerman(m - 1, Akerman(m, n - 1));
}


int firstNumber = CheckInput("Введите первое число: ");
int secondNumber = CheckInput("Введите второе число: ");

int akerman = Akerman(firstNumber, secondNumber);
Console.WriteLine(akerman);