/*Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да



Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Число палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - не является палиндромом");
    }
}
else
{
    Console.WriteLine($"на вход требуется пятизначное число, а число {number} таковым не является");
}
*/


/*Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


int x1 = ReadInt("Введите значение координаты X для первой точки: ");
int y1 = ReadInt("Теперь значение Y: ");
int z1 = ReadInt("И значение Z для нее же: ");
int x2 = ReadInt("А теперь тоже самое для второй точки X: ");
int y2 = ReadInt("Хначение Y: ");
int z2 = ReadInt("И значение Z для нее же: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Координаты точки A: ({x1}, {y1}, {z1}); координаты точки B: ({x2}, {y2}, {z2}) а расстояние между ними {length}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/


/*Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125


int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i}, ");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/
