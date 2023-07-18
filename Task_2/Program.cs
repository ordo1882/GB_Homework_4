// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter the number:");
string number = Console.ReadLine();

bool IsValidateNumber(string num, int position) // Реализация функции проверки наличия ненужных символов и негативных чисел
{
    if (!Char.IsDigit(num, position))
    {
        Console.WriteLine("Only digits or positive number are allowed.");
        return false;
    }
    return true;
}

int GetSumDigits() // Реализация функции суммирования цифр
{
    int sum = 0;

    for (int i = 0; i < number.Length; i++)
    {
        if (!IsValidateNumber(number, i)) // Вызов функции проверки наличия ненужных символов и негативных чисел
        {
            return 0; // В случае провала программа останавливается
        }
        else
        {
            int digit = (int)Char.GetNumericValue(number[i]); // Преобразование цифры из char в int 
            sum += digit;
        }
    }

    return sum;
}

Console.WriteLine(GetSumDigits());