/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int number = ReadInt("Введите число: ");
if (number <= 100 && number > 0 || number >= -100 && number < 0)
{
    Console.WriteLine("Третьей цифры нет");
}
if (number >= 100 && number < 1000 || number <= -100 && number > -1000)
{
    int thirdNumber = number % 10;
    Console.WriteLine(thirdNumber);
}
while (number> 1000 || number< -1000)
{
    number = number / 10;
    if ( number < 1000)
    {
        int thirdNumber = number % 10;
        Console.WriteLine(thirdNumber); 
    }


}


int ReadInt(string message)
{
Console.Write(message);
return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}