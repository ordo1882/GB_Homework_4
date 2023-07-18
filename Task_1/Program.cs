// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Enter the first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

bool IsValidateNumber(int num) // Реализация функции проверки наличия негативного числа
{
    if (num < 0)
    {
        Console.WriteLine("Need to be a positive number");
        return false;
    }
    else
    {
        return true;
    }
}

int GetPow() // Реализация функции возведения в степень
{
    int pow = 1;
    if(IsValidateNumber(num2)) // Вызов функции проверки наличия негативного числа
    {
        for (int i = 1; i <= num2; i++)
        {
            pow *= num1;
        }
    }
    else
    {
        Environment.Exit(0); // В случае провала программа останавливается
    }
    
    return pow;
}

Console.WriteLine(GetPow());