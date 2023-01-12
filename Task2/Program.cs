// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int ValueInput()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
void SumElementNumber(int Number)
{
int sum = 0;
while (Number > 0)
{
    sum += Number % 10;
    Number /= 10;
}
Console.WriteLine(sum);
}
int number = ValueInput();
SumElementNumber(number);