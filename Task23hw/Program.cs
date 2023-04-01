// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Num = new Random().Next(1, 10);
int arr = 1;
System.Console.WriteLine(Num);

while (arr <= Num)
{
    System.Console.WriteLine(arr * arr * arr);
    arr++;
}