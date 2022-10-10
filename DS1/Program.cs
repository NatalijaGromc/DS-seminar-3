// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int N,M,num,temp;
string userEnter;

Console.Write ("Введите число N: ");
userEnter = Console.ReadLine()!;
N = int.Parse(userEnter);
temp=N;
M=0;
while (temp>0)
{
    num=temp%10;
    M=M*10+num;
    temp=temp/10;
}
// Console.WriteLine(M);
if (N==M)
{
Console.Write($"палиндром");
}
else
{
Console.Write($"нет");
}