/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int number = ReadInt("Введите трехзначное число: ");

if(number >99 && number < 1000 || number < -99 && number > -1000)
{
    int lastDigit = number / 10 %10 ;
    Console.WriteLine(lastDigit);
}

else 
{
     Console.WriteLine("Число не трехзначное. Повторите ввод снова ");
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
