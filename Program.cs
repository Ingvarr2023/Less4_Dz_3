// See https://aka.ms/new-console-template for more information
//  Задача №3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним
//  второй – предпоследним и т.д.)

int[] CreateArray(int size, int minRange, int maxRange) // создаём метод создания массива из случайных чисел
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array; // конец метода CreateArray
}
int minRange = 10;
int maxRange = 99;
Console.Write("Введём размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrNew = CreateArray(size, minRange, maxRange);
Console.WriteLine($"Массив : [{string.Join("; ", arrNew)}]");

for (int i = arrNew.Length - 1; i>= 0; i--)
{
       Console.Write(arrNew[i] + "; ");
}

