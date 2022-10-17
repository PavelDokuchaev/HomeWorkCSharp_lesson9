/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Ввидите число N");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввидите число M");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
int temp = 0;
if (userNumber2 > userNumber1)
{
    temp = userNumber2;
    userNumber2 = userNumber1;
    userNumber1 = temp;
}

int sumNumbers = printRange(userNumber1, userNumber2);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна: {sumNumbers}");

int printRange(int N, int M)
{
    if (N < M)
    {
        return 0;
    }
    return printRange(N, M + 1) + M;
}
