// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите цифру от 1 до 7: ");
int x = Convert.ToInt32(Console.ReadLine());

switch (x)
{
    case 1:
        System.Console.WriteLine("Это понедельник - не выходной.");
        break;
    case 2:
        System.Console.WriteLine("Это вторник - не выходной.");
        break;
    case 3:
        System.Console.WriteLine("Это среда - не выходной.");
        break;
    case 4:
        System.Console.WriteLine("Это четверг - не выходной.");
        break;
    case 5:
        System.Console.WriteLine("Это пятница - не выходной, но почти выходной.");
        break;
    case 6:
        System.Console.WriteLine("Это суббота - УРА! Выходной.");
        break;
    case 7:
        System.Console.WriteLine("Это воскресенье - УРА! Выходной. Но завтра на работу.");
        break;
    default: 
        System.Console.WriteLine("Это не день недели");
        break;
}