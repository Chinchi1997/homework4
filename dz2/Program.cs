// Задача 29: Напишите программу, которая принимает на вход длину массива и в последующих строках элементы массива.
// 5
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 3
// 6, 1, 33 -> [6, 1, 33]


Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());


int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}, ");
     array[i] = int.Parse(Console.ReadLine());
}
   

Console.WriteLine($"[{string.Join(", ", array)}]");
