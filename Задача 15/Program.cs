// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

System.Console.WriteLine("Введите цифру, обзначающую день недели:");
int num = Convert.ToInt32(Console.ReadLine());
if( num>=1 && num<=5 )
{
    System.Console.WriteLine("Рабочий день");
}
else if(num ==6 || num== 7)
{
    System.Console.WriteLine("Выходной день");
}
else
{
    System.Console.WriteLine("не является номером дня недели");
}
