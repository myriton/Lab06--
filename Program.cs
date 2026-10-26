//Задание 1.1
// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }
// //Задание 1.2
// for (int i = 0; i <= 50; i+= 2)
// {
//     Console.WriteLine(i);
// }
//Задание 2
// int sum = 0;
// int count = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         sum += i;
//     }
//     if (i % 7 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Сумма: {sum}, Количество: {count}");
//Задание 3
// int number = Convert.ToInt32(Console.ReadLine());
// int totalpl = 0;
// int totalmin = 0;

// while (number != 0)
// {
//     if (number > 0)
//     {
//         totalpl++;
//         number = Convert.ToInt32(Console.ReadLine());
//     }
//     else
//     {
//         totalmin++;
//         number = Convert.ToInt32(Console.ReadLine());
//     }

// }
// Console.WriteLine($"Положительные: {totalpl}, Отрицательные: {totalmin}");
//Задание 4
// string password;
// bool isAccess = false;
// for (int i = 1; i <= 3; i++)
// {
//     Console.Write("Введите пароль: ");
//     password = Console.ReadLine();

//     if (password == "qwerty")
//     {
//         Console.WriteLine("Доступ разрешен");
//         isAccess = true;
//         break;
//     } 
//     else
//     {
//         Console.WriteLine($"Неверный пароль.");
//     }
// }
// if (!isAccess) 
// {
//     Console.WriteLine("Доступ заблокирован");
// }
//Задание 5
// int n = Convert.ToInt32(Console.ReadLine());;
// for (int i = 1; i <= 10; i++) {
//     Console.WriteLine($"{n} x {i} = {n * i}");
// }
//Задание 6
// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 == 0)
//         continue;
//     if (i % 10 == 0 && i > 20)
//         break;
//     Console.WriteLine(i);
// }
//Итоговая задача. «Угадай число»
using System.Globalization;

int secret = 42;
bool isGuessed = false;
int attempt = 0;
for (int i = 1; i <= 5; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    attempt = i;

    if (number == secret) 
    {
        Console.WriteLine($"Победа! Попыток: {attempt}");
        isGuessed = true;
        break;
    } 
else if (number < secret)
{
    Console.WriteLine("Больше");
} 
else
{
    Console.WriteLine("Меньше");
}
}
if (!isGuessed)
{
    Console.WriteLine($"Вы проиграли, число было {secret}");
}