// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];

for (int i = 0; i < M; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write($"Вы ввели {MoreZero(array)} чисел больше 0.");

int MoreZero(int[] arr)
{
    int amount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) amount += 1;
    }
    return amount;
}