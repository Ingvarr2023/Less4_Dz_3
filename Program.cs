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

// Задача 2 урока 4: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateArray(int size, int minRange, int maxRange) // создаём метод создания массива из случайных чисел
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minRange, maxRange + 1);
//     }
//     return array; // конец метода CreateArray
// }
// int minRange = 100;
// int maxRange = 999;
// Console.Write("Введём размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = CreateArray(size, minRange, maxRange);
// Console.WriteLine($"Массив: [{string.Join(";", arr)}]");
// int countEven = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] % 2 == 0)
//     {
//         countEven++;
//     }
//     // return countEven;
// }
// Console.Write("Количесво чётных чисел: " + countEven);

// Задача №1. Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.
  
// while (true)
// {
//       Console.Write("Введите текст: ");
//       string text = Console.ReadLine();
            
//   if (text == "q")
//     {
//       break;  
//     }
//     int num;
//     if (int.TryParse(text, out num))
//     {
//       Console.WriteLine("Число " + num);
//     }
//     else
//     {
//      Console.WriteLine("text" ); 
//     }
//     int sum = 0;
//     while (num > 0)
//     {      
//     int interNum = num % 10;
//      sum = sum + interNum;
//      num = num / 10; 
//     }
//     Console.WriteLine("Сумма чисел " + sum);
//      if (sum > 0 && sum % 2 == 0)
//      {
//         Console.WriteLine("Число чётное ");
//         break;
//      }
   
//     }


