/* **Задача 41:**
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223 -> 3  */

string[] input()
{
    Console.WriteLine("Введите несколько целых чисел через запятую: ");
    string? strA = Console.ReadLine();
    string[] strB = strA.Split(",");
    return strB;
}
string[] array = input();

double[] strA1 = Array.ConvertAll(array, double.Parse);
int numbers = array.Length;
Console.WriteLine("\nКоличество чисел: " + numbers);

int countZero = 0;
for (int i = 0; i < array.Length; i++)
{
    if (strA1[i] > 0)
    {
        countZero++;
    }
}
Console.WriteLine("Количество чисел больше нуля: " + countZero);