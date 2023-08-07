// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0 

int[] array = new int[5];

Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-99, 100);
    Console.Write(array[i] + " ");
}

int sumOddPositions = 0;

for (int i = 1; i < array.Length; i += 2)
{
    sumOddPositions += array[i];
}

Console.WriteLine("\nСумма элементов на нечетных позициях: " + sumOddPositions);