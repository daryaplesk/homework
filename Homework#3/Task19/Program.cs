// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Программа работает для всех целых чисел.

int Input(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool CheckPalindrom(string number)
{
    for (int i = 0, j = number.Length - 1; i < (number.Length / 2); i++, j--)
    {
        if (number[i] == number[j]) 
            continue;
        else 
            return false;
    }
    return true;
}

string number = Convert.ToString(Math.Abs(Input("Введите число: ")));

if (CheckPalindrom(number) == false) 
    System.Console.WriteLine("Это не палиндром");
else
    System.Console.WriteLine("Это палиндром");
