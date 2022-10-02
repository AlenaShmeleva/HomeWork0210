// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {   
        Console.WriteLine("Введите " + i + " элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int NewArray(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if (array[i] > 0)
        count++;
    }
return count;
}
Console.WriteLine("Сколько чисел вы хотите ввести?");
int M = Convert.ToInt32(Console.ReadLine());
int [] array = new int[M];
InputArray(array);
Console.WriteLine();
Console.WriteLine($"Введённый массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество положительных чисел в массиве:  {NewArray(array)}");