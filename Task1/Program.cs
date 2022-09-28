// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

string PalindromeTest(int number)
{
    if(number / 10000 == number % 10 && (number / 1000) % 10 == (number / 10) % 10)
    return "да";
    else
    {
        return "нет";
    }
}

int number = ReadData("Введите пятизначное число");
if( number > 9999 && number < 100000 )
{
    string result = PalindromeTest(number);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ошибка: число не пятизначное");
}