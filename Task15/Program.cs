/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int number = ReadInt("Введите число: ");

if(number >= 1 && number <= 5)
{
    Console.WriteLine("рабочий день");
}

else if(number == 7 || number == 6)
{
    Console.WriteLine("выходной");
}
else
{
    Console.WriteLine("Такого дня недели не существует! Повторите ввод!");
}



int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

